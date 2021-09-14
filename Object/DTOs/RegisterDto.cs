using System.ComponentModel.DataAnnotations;

namespace Object.DTOs
{
    public class RegisterDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirmation password not match.")]
        public string ConfirmPassword { get; set; }
    }
}