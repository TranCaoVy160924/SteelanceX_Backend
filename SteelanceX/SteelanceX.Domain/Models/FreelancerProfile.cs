#nullable disable
namespace SteelanceX.Domain.Models;
public class FreelancerProfile
{
    public int Id { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }

    public int AppUserId { get; set; }
    public virtual AppUser AppUser { get; set; }
    public virtual ICollection<Application> Applications { get; set; }
    public virtual ICollection<JobProgress> JobProgress { get; set; }
    public virtual ICollection<FreelancerCategory> Categories { get; set; }
}
