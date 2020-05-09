﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventPlanner.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Group")]
        public string Name { get; set; }
    }
}