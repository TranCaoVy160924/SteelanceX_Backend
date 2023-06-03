using SteelanceX.Data.EF;
using SteelanceX.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelanceX.DataAccess.DataAccessObjects;
public class CategoryRepository : RepositoryBase<Category>
{
    public CategoryRepository(SteelanceXDbContext dbContext) : base(dbContext) { }
}

