using MeetingRoomSystem.Models.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MeetingRoomSystem.Data
{
    public class MeetingDbContext : IdentityDbContext<ApplicationUser>
    {
        public MeetingDbContext(DbContextOptions<MeetingDbContext> options) : base(options)
        {
            
        }
    }
}
