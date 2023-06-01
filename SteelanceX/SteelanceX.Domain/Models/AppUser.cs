using Microsoft.AspNetCore.Identity;

namespace SteelanceX.Domain.Models;
public class AppUser : IdentityUser<int>
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Address { get; set; }

    public virtual BusinessProfile? BusinessProfile { get; set; }
    public virtual FreelancerProfile? FreelancerProfile { get; set; }
}
