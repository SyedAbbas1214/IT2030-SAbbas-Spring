using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage ="We need Student Last Name")]
        [StringLength(50, ErrorMessage ="Its Too Long")]
        public string StudentLastName { get; set; }
        [Required(ErrorMessage = "Student First name Needed ")]
        [StringLength(50, ErrorMessage ="First name Shouldn't exceed more than 50 Characters")]

        public string StudentFirstName { get; set; }
    }
}