#nullable disable
namespace SteelanceX.Domain.Models;
public class Application
{
    public int Id { get; set; }
    public bool IsAccepted { get; set; }
    public DateTime CreateDate { get; set; }

    public int JobId { get; set; }
    public virtual Job Job { get; set; }

    public int FreelancerProfileId { get; set; }
    public virtual FreelancerProfile FreelancerProfile { get; set; }
}
