using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using SteelanceX.DataAccess.DataAccessObjects;
using SteelanceX.Domain.Models;

namespace SteelanceX.Application.Controllers;

public class JobsController : ODataController
{
    private readonly JobRepository _jobRepo;

    public JobsController(JobRepository jobRepo)
    {
        _jobRepo = jobRepo;
    }

    [EnableQuery]
    public ActionResult<IQueryable<Job>> Get()
    {
        return Ok(_jobRepo.QueryAllAsync().Result);
    }

    [EnableQuery]
    public ActionResult<Job> Get([FromRoute] int key)
    {
        var job = _jobRepo.QueryAllAsync().Result
            .SingleOrDefault(d => d.Id.Equals(key));

        if (job == null)
        {
            return NotFound();
        }

        return Ok(job);
    }

    public async Task<ActionResult> Post([FromBody] Job job)
    {
        try
        {
            await _jobRepo.CreateAsync(job);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return Created(job);
    }

    public async Task<ActionResult> Patch([FromRoute] int key, [FromBody] Delta<Job> delta)
    {
        var project = _jobRepo.QueryAllAsync().Result
            .SingleOrDefault(d => d.Id == key);

        if (project == null)
        {
            return NotFound();
        }

        try
        {
            delta.Patch(project);
            await _jobRepo.UpdateAsync(project);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return Updated(project);
    }

    public async Task<ActionResult> Delete([FromRoute] int key)
    {
        var project = _jobRepo.QueryAllAsync().Result
            .SingleOrDefault(d => d.Id == key);

        try
        {
            if (project != null)
            {
                await _jobRepo.DeleteAsync(project);
            }
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return NoContent();
    }
}
