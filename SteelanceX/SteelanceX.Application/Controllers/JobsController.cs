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

namespace SteelanceX.Application.Controllers;

public class JobsController : ODataController
{
    private readonly JobRepository _jobRepo;
    private readonly JobCategoryRepository _jobCatRepo;
    private readonly CategoryRepository _catRepo;
    private readonly IMapper _mapper;

    public JobsController(JobRepository jobRepo,
        JobCategoryRepository jobCatRepo,
        CategoryRepository catRepo,
        IMapper mapper)
    {
        _jobRepo = jobRepo;
        _jobCatRepo = jobCatRepo;
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
    [EnableQuery(PageSize = 10)]
    public ActionResult<JobResponse> GetJobs()
    {
        var jobs = _jobRepo.QueryAll()
            .Where(j => j.IsActive)
            .Include(j => j.Categories);
        return Ok(_mapper.ProjectTo<JobResponse>(jobs));
    }

    public async Task<ActionResult> Post([FromBody] JobResponse createRequest)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                throw new Exception(ModelState.ValidateError());
            }

            //Job job = _mapper.Map<Job>(createRequest);
            //if (job.ApplyExpireDate < DateTime.Today)
            //{
            //    throw new Exception("Apply expire date must be later than today");
            //}
            //foreach (int catId in createRequest.Categories)
            //{
            //    if (await _catRepo.Get(catId) == null)
            //    {
            //        throw new Exception("Category not exist");
            //    }
            //}
            //await _jobRepo.CreateAsync(job);

            //job.Categories = new List<JobCategory>();
            //foreach (int catId in createRequest.Categories)
            //{
            //    job.Categories.Add(new JobCategory
            //    {
            //        JobId = job.Id,
            //        CategoryId = catId
            //    });
            //}
            //await _jobRepo.UpdateAsync(job);

            //return Ok(_mapper.Map<JobResponse>(job));

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
