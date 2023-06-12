namespace SteelanceX.Contracts.DataTransferObjects.FreelancerProfile.Response;
public class FreelancerResponse
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string ResumeUrl { get; set; }
    public double Price { get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }
    public string Address { get; set; }

    public int AppUserId { get; set; }
    public string Fullname { get; set; }
    public List<int> Categories { get; set; }
}
