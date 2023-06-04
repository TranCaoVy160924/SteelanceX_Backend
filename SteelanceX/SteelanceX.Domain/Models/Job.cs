#nullable disable
namespace SteelanceX.Domain.Models;
public class Job
{
    public int Id { get; set; }
    public bool IsActive { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Offer { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ApplyExpireDate { get; set; }
    public DateTime JobExpiredDate { get; set; }
    public string ImageUrl { get; set; }
    public string JobDescriptionFileUrl { get; set; }
    public int BusinessProfileId { get; set; }

    public virtual BusinessProfile BusinessProfile { get; set; }
    public virtual ICollection<Application> Applications { get; set; }
    public virtual ICollection<JobProgress> JobProgress { get; set; }
    public virtual ICollection<JobCategory> Categories { get; set; }
}
