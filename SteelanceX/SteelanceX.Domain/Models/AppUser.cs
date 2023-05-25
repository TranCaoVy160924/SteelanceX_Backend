using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelanceX.Domain.Models;
public class AppUser: IdentityUser<Guid>
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Address { get; set; }

    public virtual BusinessProfile? BusinessProfile { get; set; }
    public virtual FreelancerProfile? FreelancerProfile { get; set; }
}
