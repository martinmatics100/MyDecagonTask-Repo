using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyHomePage.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [RegularExpression(@"^[a-zA-Z]{2,50}$", ErrorMessage = "Name Should begin with UpperCase")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [RegularExpression(@"^[a-zA-Z]{2,50}$", ErrorMessage = "Name Should begin with UpperCase")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        //[ConfigurationKeyName(nameof(FirstName))]
        public string? LastName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@(gmail\.com|yahoo\.com|outlook\.com)$", ErrorMessage = "Please enter a valid Email")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]

        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [RegularExpression(@"^(?=.*[@#$%^&!])(?=.*[a-zA-Z0-9]).{6,}$",
        ErrorMessage = "Password must be 6 to 20 characters long and contain at least one letter, one digit, and one special character.")]
        public string? PassWord { get; set; }
    }
}
