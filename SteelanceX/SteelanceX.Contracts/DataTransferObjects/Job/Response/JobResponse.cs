using SteelanceX.Contract.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace SteelanceX.Contracts.DataTransferObjects.Job.Response;
public class JobResponse
{
    public int Id { get; set; } = 0;

    public bool IsActive { get; set; } = true;

    [Required]
    [MinLength(1)]
    public string Name { get; set; }

    [Required]
    [MinLength(1)]
    public string Description { get; set; }

    [Required]
    [Range(1, Double.MaxValue)]
    public double Offer { get; set; }

    [Required]
    public DateTime CreatedDate { get; set; }

    [Required]
    [DateLaterThan("CreatedDate", ErrorMessage = "Expired date must later than create date")]
    public DateTime ApplyExpireDate { get; set; }

    [Required]
    [Range(1, Double.MaxValue)]
    public int BusinessProfileId { get; set; }

    public string BusinessName { get; set; } = "";

    public List<int> Categories { get; set; } = new List<int>();
}
