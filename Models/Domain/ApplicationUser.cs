using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MeetingRoomSystem.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
