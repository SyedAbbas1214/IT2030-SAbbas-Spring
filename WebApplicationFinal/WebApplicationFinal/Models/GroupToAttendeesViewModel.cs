﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventPlanner.Models
{
    public class GroupToAttendeesViewModel
    {
        public Group Group { get; set; }
        public List<ApplicationUser> CurrentUsers { get; set; }
    }
}