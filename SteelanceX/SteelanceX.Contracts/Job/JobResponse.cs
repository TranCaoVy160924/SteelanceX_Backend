using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelanceX.Contracts.DataTransferObjects.Job;
public class JobResponse
{
    public int Id { get; set; }
    public bool IsActive { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Offer { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ApplyExpireDate { get; set; }
    public DateTime JobExpiredDate { get; set; }
    public int BusinessProfileId { get; set; }
    public string BusinessName { get; set; }
    public List<int> Categories { get; set; }
}
