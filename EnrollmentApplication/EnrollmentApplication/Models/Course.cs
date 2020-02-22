using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Course Title is Required")]
        [StringLength(150, ErrorMessage = "Couse Title Name is too long")]

        public string CourseTitle { get; set; }
        
        public string CourseDescription { get; set; }

        [Required(ErrorMessage = "Course Credits are Required")]
        [Range(typeof(int), "1", "4", ErrorMessage ="It can only be between 1 and 4" )]
        public int CourseCredits { get; set; }

    }
}