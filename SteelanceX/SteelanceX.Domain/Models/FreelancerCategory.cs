namespace SteelanceX.Domain.Models;
public class FreelancerCategory
{
    public int FreelancerProfileId { get; set; }
    public virtual FreelancerProfile FreelancerProfile { get; set; }

    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
}
