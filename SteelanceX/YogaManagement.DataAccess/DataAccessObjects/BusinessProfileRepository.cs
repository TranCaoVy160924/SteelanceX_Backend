using SteelanceX.Data.EF;
using SteelanceX.Domain.Models;

namespace SteelanceX.DataAccess.DataAccessObjects;
public class BusinessProfileRepository : RepositoryBase<BusinessProfile>
{
    public BusinessProfileRepository(SteelanceXDbContext dbContext) : base(dbContext) { }
}

