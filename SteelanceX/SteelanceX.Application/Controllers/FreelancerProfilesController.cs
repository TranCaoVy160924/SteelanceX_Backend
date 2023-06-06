using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using SteelanceX.DataAccess.DataAccessObjects;
using SteelanceX.Domain.Models;

namespace SteelanceX.Application.Controllers;

public class FreelancerProfilesController : ODataController
{
    private readonly FreelancerProfileRepository _freelancerRepo;

    public FreelancerProfilesController(FreelancerProfileRepository freelancerRepo)
    {
        _freelancerRepo = freelancerRepo;
    }

    [EnableQuery]
    public ActionResult<IQueryable<FreelancerProfile>> Get()
    {
        return Ok(_freelancerRepo.QueryAll());
    }

    [EnableQuery]
    public ActionResult<FreelancerProfile> Get([FromRoute] int key)
    {
        var freelancer = _freelancerRepo.QueryAll()
            .SingleOrDefault(d => d.Id.Equals(key));

        if (freelancer == null)
        {
            return NotFound();
        }

        return Ok(freelancer);
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