using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GymBookingApplication.Models
{
    public class ApplicationUser : IdentityUser
#nullable disable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public DateTime TimeOfRegistration { get; set; }
        public ICollection<GymClass> GymClasses { get; set; } = new List<GymClass>();   //Nav
        public ICollection<ApplicationUserGymClass> ApplicationUserGymClasses { get; set; } = new List<ApplicationUserGymClass>();  //Nav
    }
}
