namespace SteelanceX.Domain.Models;
public class FreelancerProfile
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string ResumeUrl { get; set; }

    public int AppUserId { get; set; }
    public virtual AppUser AppUser { get; set; }
    public virtual ICollection<Application>? Applications { get; set; }
    public virtual ICollection<JobProgress>? JobProgress { get; set; }
    public virtual ICollection<FreelancerCategory>? Categories { get; set; }
}
