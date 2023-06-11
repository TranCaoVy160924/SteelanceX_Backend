using SteelanceX.Contract.ValidationAttributes;
using SteelanceX.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelanceX.Contracts.DataTransferObjects.Job.Request;
public class CreateJobRequest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Offer { get; set; }
    public string ApplyExpireDate { get; set; }
    public int BusinessProfileId { get; set; }
    public List<int> RequiredCategories { get; set; }
}
