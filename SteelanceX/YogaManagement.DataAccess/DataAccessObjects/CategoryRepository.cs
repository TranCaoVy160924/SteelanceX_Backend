using SteelanceX.Data.EF;
using SteelanceX.Domain.Models;

namespace SteelanceX.DataAccess.DataAccessObjects;
public class CategoryRepository : RepositoryBase<Category>
{
    public CategoryRepository(SteelanceXDbContext dbContext) : base(dbContext) { }
}

