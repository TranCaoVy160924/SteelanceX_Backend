using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using SteelanceX.Application.Utilities;
using SteelanceX.Contracts.DataTransferObjects.Job.Request;
using SteelanceX.Contracts.DataTransferObjects.Job.Response;
using SteelanceX.DataAccess.DataAccessObjects;
using SteelanceX.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Claims;

namespace SteelanceX.Application.Controllers;

public class JobsController : ODataController
{
    private readonly JobRepository _jobRepo;
    private readonly CategoryRepository _catRepo;
    private readonly ApplicationRepository _applyRepo;
    private readonly IMapper _mapper;

    public JobsController(JobRepository jobRepo,
        CategoryRepository catRepo,
        IMapper mapper)
    {
        _jobRepo = jobRepo;
        _catRepo = catRepo;
        _mapper = mapper;
    }

    [HttpGet]
    [EnableQuery(PageSize = 10)]
    public ActionResult<JobResponse> GetOpenJobs()
    {
        var jobs = _jobRepo.QueryAll()
            .Where(j => j.IsActive
                && j.ApplyExpireDate > DateTime.Now)
            .Include(j => j.Categories)
            .Include(j => j.BusinessProfile);

        return Ok(_mapper.ProjectTo<JobResponse>(jobs));
    }

    [HttpGet]
    [EnableQuery]
    public ActionResult<JobResponse> Get([FromRoute] int key)
    {
        var job = _jobRepo.QueryAll()
            .Include(j => j.Categories)
            .ThenInclude(c => c.Category)
            .Include(j => j.BusinessProfile)
            .SingleOrDefault(d => d.Id.Equals(key));

        if (job == null)
        {
            return NotFound();
        }

        return Ok(_mapper.Map<JobResponse>(job));
    }

    [HttpGet]
    [EnableQuery]
    public ActionResult<JobResponse> Get()
    {
        var jobs = _jobRepo.QueryAll()
            .Where(j => j.IsActive
                && j.ApplyExpireDate > DateTime.Now)
            .Include(j => j.Categories)
            .Include(j => j.BusinessProfile);

        return Ok(_mapper.ProjectTo<JobResponse>(jobs));
    }

    [Authorize(Roles = "Business")]
    public async Task<ActionResult> Post([FromBody] JobResponse createRequest)
    {
        var isPremium = User.Claims.SingleOrDefault(x => x.Type == "IsPremium").Value;
        if (!bool.Parse(isPremium))
        {
            return BadRequest("Not paid user");
        }

        try
        {
            if (!ModelState.IsValid)
            {
                throw new Exception(ModelState.ValidateError());
            }

            Job job = _mapper.Map<Job>(createRequest);
            if (job.ApplyExpireDate < DateTime.Today)
            {
                throw new Exception("Apply expire date must be later than today");
            }
            foreach (int catId in createRequest.Categories)
            {
                if (await _catRepo.Get(catId) == null)
                {
                    throw new Exception("Category not exist");
                }
            }
            await _jobRepo.CreateAsync(job);

            job.Categories = new List<JobCategory>();
            foreach (int catId in createRequest.Categories)
            {
                job.Categories.Add(new JobCategory
                {
                    JobId = job.Id,
                    CategoryId = catId
                });
            }
            await _jobRepo.UpdateAsync(job);

            return Created(createRequest);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [Authorize]
    [HttpPut("odata/Jobs/status/{jobId}")]
    public async Task<IActionResult> ToggleJobStatus([FromRoute] int jobId)
    {
        var job = _jobRepo.QueryAll()
            .SingleOrDefault(j => j.Id.Equals(jobId)
                && j.ApplyExpireDate > DateTime.Now);
        if (job == null)
        {
            return BadRequest("Job not exist");
        }


        try
        {
            job.IsActive = !job.IsActive;
            await _jobRepo.UpdateAsync(job);

            return Ok();
        }

        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    

    //public async Task<ActionResult> Patch([FromRoute] int key, [FromBody] Delta<Job> delta)
    //{
    //    var project = _jobRepo.QueryAll()
    //        .SingleOrDefault(d => d.Id == key);

    //    if (project == null)
    //    {
    //        return NotFound();
    //    }

    //    try
    //    {
    //        delta.Patch(project);
    //        await _jobRepo.UpdateAsync(project);
    //    }
    //    catch (Exception ex)
    //    {
    //        return BadRequest(ex.Message);
    //    }

    //    return Ok(project);
    //}

    //public async Task<ActionResult> Delete([FromRoute] int key)
    //{
    //    var project = _jobRepo.QueryAll()
    //        .SingleOrDefault(d => d.Id == key);

    //    try
    //    {
    //        if (project != null)
    //        {
    //            await _jobRepo.DeleteAsync(project);
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        return BadRequest(ex.Message);
    //    }

    //    return NoContent();
    //}
}
