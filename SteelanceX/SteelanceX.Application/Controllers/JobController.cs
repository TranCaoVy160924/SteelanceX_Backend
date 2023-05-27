using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using SteelanceX.Business.JobRepository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SteelanceX.Application.Controllers;
[Route("api/[controller]")]
[ApiController]
public class JobController : ODataController
{
    private readonly IJobRepository _jobRepository;

    public JobController(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }

    // GET: api/<JobController>
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        return Ok(await _jobRepository.GetAllAsync());
    }

    // GET api/<JobController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<JobController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<JobController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<JobController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
