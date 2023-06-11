using SteelanceX.Data.EF;
using SteelanceX.Domain.Models;

namespace SteelanceX.DataAccess.DataAccessObjects;
public class FreelancerProfileRepository : RepositoryBase<FreelancerProfile>
{
    public FreelancerProfileRepository(SteelanceXDbContext dbContext) : base(dbContext) { }
}
