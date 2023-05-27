using SteelanceX.Domain.Models;

namespace SteelanceX.Business.JobRepository;
public interface IJobRepository
{
    Task<List<Job>> GetAllAsync();
}
