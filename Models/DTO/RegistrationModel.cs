using System.ComponentModel.DataAnnotations;

namespace MeetingRoomSystem.Models.DTO
{
    public class RegistrationModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage= "Password must contain minimum eight characters, at least one uppercase letter, one lowercase letter, one number and one special character")]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string PasswordConfirmed { get; set; }
        public string? Role { get; set; }

    }
}
