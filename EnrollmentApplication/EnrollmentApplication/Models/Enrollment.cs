using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }
        [Required(ErrorMessage = "You Must Choose a Grade")]
        [RegularExpression(@"[A-F]", ErrorMessage = "It should be between A and F")]
        public virtual string Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        public virtual Boolean IsActive { get; set; }

        [Required(ErrorMessage ="You must Choose one Campus")]
        public virtual string AssignedCampus { get; set; }
        [Required(ErrorMessage = "Please choose one Semester")]
        public virtual string EnrollmentSemester { get; set; }
        [Required(ErrorMessage = "It cannot be less than 2018")]
        [Range(typeof(int), "2018", "2030")]
        public virtual int EnrollmentYear { get; set; }
    }
}