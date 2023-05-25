using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelanceX.Domain.Models;
public class BusinessProfile
{
    public int Id { get; set; }

    public Guid AppUserId { get; set; }
    public virtual AppUser AppUser { get; set; }
    public virtual ICollection<Job>? Jobs { get; set; }
}
