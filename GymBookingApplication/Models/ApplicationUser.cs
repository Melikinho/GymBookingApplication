using Microsoft.AspNetCore.Identity;

namespace GymBookingApplication.Models
{
    public class ApplicationUser : IdentityUser
#nullable disable
    {
        public GymClass GymClass;
    }
}
