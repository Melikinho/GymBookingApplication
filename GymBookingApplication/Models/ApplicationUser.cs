using Microsoft.AspNetCore.Identity;

namespace GymBookingApplication.Models
{
    public class ApplicationUser : IdentityUser
#nullable disable
    {
        public int UserId { get; set; }
        public string Name { get; set; }    
        public ICollection<ApplicationUserGymClass> ParticipatingMembers { get; set; }
    }
}
