using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Student : IValidatableObject
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage ="We need Student Last Name")]
        [StringLength(50, ErrorMessage ="Its Too Long")]
        public string StudentLastName { get; set; }
        [Required(ErrorMessage = "Student First name Needed ")]
        [StringLength(50, ErrorMessage ="First name Shouldn't exceed more than 50 Characters")]

        public string Course { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Address2 == Address1)
            {
                yield return (new ValidationResult("Address2 Cannaot be as same as Address1"));
            }
            if (State.Count() > 2)
            {
                yield return (new ValidationResult("State has to be 2 digits."));
            }
            if (Zipcode.Count() > 5)
            {
                yield return (new ValidationResult("Zip Code Can't be longer than 5 Digits."));

            }

            
        }
    }
}