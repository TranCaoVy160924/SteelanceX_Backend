using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelanceX.Domain.Models;
public class AppRole: IdentityRole<Guid>
{
    public string RoleName { get; set; }    
}
