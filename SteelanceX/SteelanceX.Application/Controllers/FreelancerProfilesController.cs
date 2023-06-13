using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using SteelanceX.Application.Utilities;
using SteelanceX.Contracts.DataTransferObjects.FreelancerProfile.Response;
using SteelanceX.DataAccess.DataAccessObjects;
using SteelanceX.Domain.Models;

namespace SteelanceX.Application.Controllers;

public class FreelancerProfilesController : ODataController
{
    private readonly FreelancerProfileRepository _freelancerRepo;
    private readonly CategoryRepository _catRepo;
    private readonly FreelancerCategoryRepository _fcRepo;
    private readonly IMapper _mapper;

    public FreelancerProfilesController(FreelancerProfileRepository freelancerRepo
                                        , CategoryRepository catRepo
                                        , FreelancerCategoryRepository fcRepo
                                        , IMapper mapper)
    {
        _freelancerRepo = freelancerRepo;
        _catRepo = catRepo;
        _fcRepo = fcRepo;
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

    public async Task<ActionResult> Post([FromBody] FreelancerResponse freelancerProfile)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                throw new Exception(ModelState.ValidateError());
            }

            FreelancerProfile newProfile = _mapper.Map<FreelancerProfile>(freelancerProfile);

            foreach (int catId in freelancerProfile.Categories)
            {
                if (await _catRepo.Get(catId) == null)
                {
                    throw new Exception("Category not exist");
                }
            }
            await _freelancerRepo.CreateAsync(newProfile);

            newProfile.Categories = new List<FreelancerCategory>();
            foreach (int catId in freelancerProfile.Categories)
            {
                newProfile.Categories.Add(new FreelancerCategory
                {
                    FreelancerProfileId = newProfile.Id,
                    CategoryId = catId
                });
            }
            await _freelancerRepo.UpdateAsync(newProfile);

            return Created(freelancerProfile);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    public async Task<ActionResult> Put([FromRoute] int key, [FromBody] FreelancerResponse freelancerProfile)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                throw new Exception(ModelState.ValidateError());
            }

            var updateProfile = _freelancerRepo.QueryAll()
            .SingleOrDefault(d => d.Id == key);

            var oldCate = _fcRepo.QueryAll().Where(c => c.FreelancerProfileId == key);

            foreach (var o in oldCate)
            {
                updateProfile.Categories.Remove(o);
            }

            foreach (int catId in freelancerProfile.Categories)
            {
                if (await _catRepo.Get(catId) == null)
                {
                    throw new Exception("Category not exist");
                }
            }

            if (updateProfile == null)
            {
                return NotFound();
            } 

            updateProfile.Description = freelancerProfile.Description;
            updateProfile.ResumeUrl = freelancerProfile.ResumeUrl;
            updateProfile.Price = freelancerProfile.Price;
            updateProfile.Title = freelancerProfile.Title;
            updateProfile.ImageUrl = freelancerProfile.ImageUrl;

            updateProfile.Categories = new List<FreelancerCategory>();

            foreach (int catId in freelancerProfile.Categories)
            {
                updateProfile.Categories.Add(new FreelancerCategory
                {
                    FreelancerProfileId = updateProfile.Id,
                    CategoryId = catId
                });
            }

            await _freelancerRepo.UpdateAsync(updateProfile);

            return Ok(freelancerProfile);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    //public async Task<ActionResult> Patch([FromRoute] int key, [FromBody] Delta<FreelancerResponse> delta)
    //{
    //    var freelancer = _freelancerRepo.QueryAll()
    //        .SingleOrDefault(d => d.Id == key);

    //    if (freelancer == null)
    //    {
    //        return NotFound();
    //    }

    //    try
    //    {
    //        var updateProfile = _mapper.Map<FreelancerResponse>(freelancer);
    //        delta.Patch(updateProfile);
    //        await _freelancerRepo.UpdateAsync(freelancer);
    //    }
    //    catch (Exception ex)
    //    {
    //        return BadRequest(ex.Message);
    //    }

    //    return Updated(freelancer);
    //}

    //public async Task<ActionResult> Delete([FromRoute] int key)
    //{
    //    var freelancer = _freelancerRepo.QueryAll()
    //        .SingleOrDefault(d => d.Id == key);

    //    try
    //    {
    //        if (freelancer != null)
    //        {
    //            await _freelancerRepo.DeleteAsync(freelancer);
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        return BadRequest(ex.Message);
    //    }

    //    return NoContent();
    //}
}