using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SteelanceX.Domain.Models;
public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<JobCategory> JobCategories { get; set; }
    public virtual ICollection<FreelancerCategory> FreelancerCategories { get; set; }
}
