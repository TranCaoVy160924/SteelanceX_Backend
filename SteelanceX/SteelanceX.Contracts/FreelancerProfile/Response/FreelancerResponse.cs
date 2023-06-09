using SteelanceX.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelanceX.Contracts.FreelancerProfile.Response;
public class FreelancerResponse
{
    public int Id { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string Title { get; set; }

    public int AppUserId { get; set; }
    public string Fullname { get; set; }
    public List<int> Categories { get; set; }
}
