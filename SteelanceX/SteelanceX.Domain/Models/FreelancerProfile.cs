#nullable disable
namespace SteelanceX.Domain.Models;
public class FreelancerProfile
{
    public int Id { get; set; }
    public string Description { get; set; }

    public int AppUserId { get; set; }
    public string Fullname  { get; set; }
    public List<int> Categories { get; set; }
}
