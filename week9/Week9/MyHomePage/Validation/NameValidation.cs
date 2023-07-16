using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MyHomePage.Validation
{
    public class NameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string Name = value.ToString();

                // Define phone number validation logic
                string pattern = @"^[a-zA-Z]{2,50}$";
                if (!Regex.IsMatch(Name, pattern))
                {
                    return new ValidationResult(ErrorMessage);
                }
            }

            return ValidationResult.Success;
        }
    }
}
