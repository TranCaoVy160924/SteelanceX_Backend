namespace SteelanceX.Domain.Models;
public class JobProgress
{
    public int Id { get; set; }
    public bool IsFinish { get; set; }
    public double Salary { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime ExpectedFinishDate { get; set; }

    public int JobId { get; set; }
    public virtual Job Job { get; set; }

    public int FreelancerProfileId { get; set; }
    public virtual FreelancerProfile FreelancerProfile { get; set; }
}
