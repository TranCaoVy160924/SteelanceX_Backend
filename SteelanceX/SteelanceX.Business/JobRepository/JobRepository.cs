using Microsoft.EntityFrameworkCore;
using SteelanceX.Domain.Models;
using YogaManagement.DataAccess.DataAccessObjects;

namespace SteelanceX.Business.JobRepository;
public class JobRepository : IJobRepository
{
    private readonly DAOBase<Job> _jobDao;

    public JobRepository(DAOBase<Job> jobDao)
    {
        _jobDao = jobDao;
    }

    public async Task<List<Job>> GetAllAsync()
    {
        try
        {
            var query = await _jobDao.QueryAllAsync();
            return await query.ToListAsync();
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
