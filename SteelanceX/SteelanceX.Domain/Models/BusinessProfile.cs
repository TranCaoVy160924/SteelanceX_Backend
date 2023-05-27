namespace SteelanceX.Domain.Models;
public class BusinessProfile
{
    public int Id { get; set; }

    public Guid AppUserId { get; set; }
    public virtual AppUser AppUser { get; set; }
    public virtual ICollection<Job>? Jobs { get; set; }
}
