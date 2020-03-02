using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
        readonly string v;

        

        public InvalidCharsAttribute(string v) : base("{0} Notes contains unacceptable characters! ")
        {
            this.v = v;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if ((string)value == v)
                {
                    var errormessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errormessage);
                }
            }
            return ValidationResult.Success;
        }

    }
}