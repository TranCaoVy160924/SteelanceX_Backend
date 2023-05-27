using Microsoft.Extensions.Caching.Distributed;
using SteelanceX.Data.EF;
using SteelanceX.Domain.Models;

namespace YogaManagement.DataAccess.DataAccessObjects;
public class JobDAO : DAOBase<Job>
{
    public JobDAO(SteelanceXDbContext dbContext, IDistributedCache cache)
        : base(dbContext, cache) { }
}
