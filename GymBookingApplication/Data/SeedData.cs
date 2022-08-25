using Microsoft.AspNetCore.Identity;
using GymBookingApplication.Models;

namespace GymBookingApplication.Data

{
    public class SeedData
    {
        public static async Task InitAsync(ApplicationDbContext db, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, string aPassword)
        {

            await roleManager.CreateAsync(new IdentityRole() { Name = "Admin" });

            {
                var adminUser = new ApplicationUser()
                {
                    Email = "admin@jimmysgym.com",
                    UserName = "admin@jimmysgym.com",
                    FirstName = "Admin",
                    LastName = "Admins",
                    EmailConfirmed = true
                };
            }
        }


    }
}
