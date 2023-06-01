using Microsoft.Extensions.Caching.Distributed;
using SteelanceX.Data.EF;
using SteelanceX.Domain.Models;

namespace SteelanceX.DataAccess.DataAccessObjects;
public class JobRepository : RepositoryBase<Job>
{
    public JobRepository(SteelanceXDbContext dbContext) : base(dbContext) { }
}
