using Microsoft.AspNetCore.Identity;

namespace GymBookingApplication.Models
{
    public class ApplicationUser : IdentityUser
#nullable disable
    {
        public ICollection<GymClass> GymClasses { get; set; } = new List<GymClass>();   //Nav
        public ICollection<ApplicationUserGymClass> ApplicationUserGymClasses { get; set; } = new List<ApplicationUserGymClass>();  //Nav
    }
}
