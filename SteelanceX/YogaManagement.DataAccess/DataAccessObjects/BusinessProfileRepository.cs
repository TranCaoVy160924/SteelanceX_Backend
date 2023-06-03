using SteelanceX.Data.EF;
using SteelanceX.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelanceX.DataAccess.DataAccessObjects;
public class BusinessProfileRepository : RepositoryBase<BusinessProfile>
{
    public BusinessProfileRepository(SteelanceXDbContext dbContext) : base(dbContext) { }
}

