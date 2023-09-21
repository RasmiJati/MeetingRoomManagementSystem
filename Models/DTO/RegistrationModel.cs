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
        [RegularExpression("\"^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$\"",ErrorMessage= "Minimum eight characters, at least one uppercase letter, one lowercase letter, one number and one special character")]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string PasswordConfirmed { get; set; }
        public string? Role { get; set; }

    }
}
