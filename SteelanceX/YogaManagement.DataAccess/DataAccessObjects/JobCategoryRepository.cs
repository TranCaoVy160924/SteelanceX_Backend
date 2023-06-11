using SteelanceX.Data.EF;
using SteelanceX.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelanceX.DataAccess.DataAccessObjects;
public class JobCategoryRepository : RepositoryBase<JobCategory>
{
    public JobCategoryRepository(SteelanceXDbContext _dbContext) : base(_dbContext) { }
}
