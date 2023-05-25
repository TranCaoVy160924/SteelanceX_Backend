﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelanceX.Domain.Models;
public class JobCategory
{
    public int JobId { get; set; }
    public virtual Job Job { get; set; }

    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
}
