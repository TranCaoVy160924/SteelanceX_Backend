using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using SteelanceX.Contracts.DataTransferObjects.FreelancerProfile.Response;
using SteelanceX.DataAccess.DataAccessObjects;
using SteelanceX.Domain.Models;

namespace SteelanceX.Application.Controllers;

public class FreelancerProfilesController : ODataController
{
    private readonly FreelancerProfileRepository _freelancerRepo;
    private readonly IMapper _mapper;

    public FreelancerProfilesController(FreelancerProfileRepository freelancerRepo
        , IMapper mapper)
    {
        _freelancerRepo = freelancerRepo;
        _mapper = mapper;
    }

    [EnableQuery(PageSize = 10)]
    public ActionResult<IQueryable<FreelancerResponse>> Get()
    {
        var freelancers = _freelancerRepo.QueryAll()
            .Include(f => f.Categories)
            .Include(f => f.AppUser);
        return Ok(_mapper.ProjectTo<FreelancerResponse>(freelancers));
    }

    [EnableQuery]
    public ActionResult<FreelancerResponse> Get([FromRoute] int key)
    {
        var freelancer = _freelancerRepo.QueryAll()
            .Include(f => f.Categories)
            .Include(f => f.AppUser)
            .SingleOrDefault(d => d.Id.Equals(key));

        if (freelancer == null)
        {
            return NotFound();
        }

        return Ok(_mapper.Map<FreelancerResponse>(freelancer));
    }

    public async Task<ActionResult> Post([FromBody] FreelancerResponse freelancer)
    {
        try
        {
            var newProfile = _mapper.Map<FreelancerProfile>(freelancer);
            await _freelancerRepo.CreateAsync(newProfile);
            return Created(newProfile);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    //public ActionResult Put([FromRoute] int key, [FromBody] FreelancerResponse freelancer)
    //{
    //    var updateProfile = _freelancerRepo.QueryAll()
    //        .SingleOrDefault(d => d.Id == key);

    //    if (updateProfile == null)
    //    {
    //        return NotFound();
    //    }

    //    customer.Name = updatedCustomer.Name;
    //    customer.CustomerType = updatedCustomer.CustomerType;
    //    customer.CreditLimit = updatedCustomer.CreditLimit;
    //    customer.CustomerSince = updatedCustomer.CustomerSince;

    //    db.SaveChanges();

    //    return Updated(customer);
    //}

    public async Task<ActionResult> Patch([FromRoute] int key, [FromBody] Delta<FreelancerResponse> delta)
    {
        var freelancer = _freelancerRepo.QueryAll()
            .SingleOrDefault(d => d.Id == key);

        if (freelancer == null)
        {
            return NotFound();
        }

        try
        {
            var updateProfile = _mapper.Map<FreelancerResponse>(freelancer);
            delta.Patch(updateProfile);
            await _freelancerRepo.UpdateAsync(freelancer);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return Updated(freelancer);
    }

    public async Task<ActionResult> Delete([FromRoute] int key)
    {
        var freelancer = _freelancerRepo.QueryAll()
            .SingleOrDefault(d => d.Id == key);

        try
        {
            if (freelancer != null)
            {
                await _freelancerRepo.DeleteAsync(freelancer);
            }
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return NoContent();
    }
}