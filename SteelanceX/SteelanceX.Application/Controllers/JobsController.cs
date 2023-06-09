using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Attributes;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using SteelanceX.Contracts.Job.Response;
using SteelanceX.DataAccess.DataAccessObjects;
using SteelanceX.Domain.Models;

namespace SteelanceX.Application.Controllers;

public class JobsController : ODataController
{
    private readonly JobRepository _jobRepo;
    private readonly IMapper _mapper;

    public JobsController(JobRepository jobRepo, IMapper mapper)
    {
        _jobRepo = jobRepo;
        _mapper = mapper;
    }

    [HttpGet]
    [EnableQuery(PageSize = 10)]
    public ActionResult<JobResponse> GetOpenJobs()
    {
        var jobs = _jobRepo.QueryAll()
            .Where(j => j.IsActive
                && j.ApplyExpireDate > DateTime.Now
                && j.JobExpiredDate > DateTime.Now)
            .Include(j => j.Categories)
            .Include(j => j.BusinessProfile);

        return Ok(_mapper.ProjectTo<JobResponse>(jobs));
    }

    [EnableQuery(PageSize = 10)]
    public ActionResult<Job> Get()
    {
        var jobs = _jobRepo.QueryAll()
            .Where(j => j.IsActive)
            .Include(j => j.Categories);
        return Ok(jobs);
    }

    [EnableQuery]
    public ActionResult<Job> Get([FromRoute] int key)
    {
        var job = _jobRepo.QueryAll()
            .Include(j => j.Categories)
            .ThenInclude(c => c.Category)
            .SingleOrDefault(d => d.Id.Equals(key));

        if (job == null)
        {
            return NotFound();
        }

        return Ok(_mapper.Map<JobResponse>(job));
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
        var project = _jobRepo.QueryAll()
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
        var project = _jobRepo.QueryAll()
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
