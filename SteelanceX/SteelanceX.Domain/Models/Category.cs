namespace SteelanceX.Domain.Models;
public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<JobCategory> JobCategories { get; set; }
    public virtual ICollection<FreelancerCategory> FreelancerCategories { get; set; }
}
