using Microsoft.AspNetCore.Identity;
using GymBookingApplication.Models;

namespace GymBookingApplication.Data

{
    public class SeedData
    {
        private static ApplicationDbContext db = default!;
        private static RoleManager<IdentityRole> roleManager = default!;
        private static UserManager<ApplicationUser> userManager = default!;
        public static async Task InitAsync(ApplicationDbContext db, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, string adminPass)
        {

            await roleManager.CreateAsync(new IdentityRole() { Name = "Admin" });

                var adminUser = new ApplicationUser()
                {
                    Email = "admin@jimmysgym.com",
                    UserName = "admin@jimmysgym.com",
                    FirstName = "Admin",
                    LastName = "Admins",
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(adminUser, adminPass);
                await userManager.AddToRoleAsync(adminUser, "Admin");
        }



    }
}
