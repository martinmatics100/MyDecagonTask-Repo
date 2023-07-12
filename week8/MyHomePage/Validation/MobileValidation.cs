using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MyHomePage.Validation
{
    public class MobileValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string phoneNumber = value.ToString();

                // Define phone number validation logic
                string pattern = @"^\+?[1-9]\d{1,14}$";
                if (!Regex.IsMatch(phoneNumber, pattern))
                {
                    return new ValidationResult(ErrorMessage);
                }
            }

            return ValidationResult.Success;
        }
    }
}
