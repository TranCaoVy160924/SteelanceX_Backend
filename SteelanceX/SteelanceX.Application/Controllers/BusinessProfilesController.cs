using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using SteelanceX.DataAccess.DataAccessObjects;
using SteelanceX.Domain.Models;

namespace SteelanceX.Application.Controllers;

public class BusinessProfilesController : ODataController
{
    private readonly BusinessProfileRepository _businessRepo;

    public BusinessProfilesController(BusinessProfileRepository businessRepo)
    {
        _businessRepo = businessRepo;
    }

    [EnableQuery]
    public ActionResult<IQueryable<BusinessProfile>> Get()
    {
        return Ok(_businessRepo.QueryAll());
    }

    [EnableQuery]
    public ActionResult<BusinessProfile> Get([FromRoute] int key)
    {
        var business = _businessRepo.QueryAll()
            .SingleOrDefault(d => d.Id.Equals(key));

        if (business == null)
        {
            return NotFound();
        }

        return Ok(business);
    }

    public async Task<ActionResult> Post([FromBody] BusinessProfile business)
    {
        try
        {
            await _businessRepo.CreateAsync(business);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return Created(business);
    }

    public async Task<ActionResult> Patch([FromRoute] int key, [FromBody] Delta<BusinessProfile> delta)
    {
        var business = _businessRepo.QueryAll()
            .SingleOrDefault(d => d.Id == key);

        if (business == null)
        {
            return NotFound();
        }

        try
        {
            delta.Patch(business);
            await _businessRepo.UpdateAsync(business);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return Updated(business);
    }

    public async Task<ActionResult> Delete([FromRoute] int key)
    {
        var business = _businessRepo.QueryAll()
            .SingleOrDefault(d => d.Id == key);

        try
        {
            if (business != null)
            {
                await _businessRepo.DeleteAsync(business);
            }
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return NoContent();
    }
}