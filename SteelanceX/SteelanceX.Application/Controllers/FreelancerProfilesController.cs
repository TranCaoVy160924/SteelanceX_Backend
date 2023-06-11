using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using SteelanceX.Contracts.FreelancerProfile.Response;
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

    public async Task<ActionResult> Post([FromBody] FreelancerProfile freelancer)
    {
        try
        {
            await _freelancerRepo.CreateAsync(freelancer);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return Created(freelancer);
    }

    public async Task<ActionResult> Patch([FromRoute] int key, [FromBody] Delta<FreelancerProfile> delta)
    {
        var freelancer = _freelancerRepo.QueryAll()
            .SingleOrDefault(d => d.Id == key);

        if (freelancer == null)
        {
            return NotFound();
        }

        try
        {
            delta.Patch(freelancer);
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