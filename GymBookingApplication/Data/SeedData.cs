using Microsoft.AspNetCore.Identity;
using GymBookingApplication.Models;

namespace GymBookingApplication.Data

{
    public class SeedData
    {
        private static RoleManager<IdentityRole> _roleManager = default!;
        public static async Task InitAsync(ApplicationDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;



            var memberRoles = new[] { "Admin", "User" };
            await GenerateRoles(memberRoles);

            var adminUser = GenerateAdminUser();
            await userManager.CreateAsync((ApplicationUser)adminUser, "Jimmy123");
            await userManager.AddToRoleAsync(adminUser, memberRoles);

            var gymClasses = GenerateGymClasses();
            db.GymClass.AddRange((GymClass)gymClasses);

            await db.SaveChangesAsync();

            var adminMember = new ApplicationUser()
            {
                Email = "Admin@JimmysGym.com",
                UserName = "Admin@JimmysGym.com",
                FirstName = "Admin",
                LastName = "Admins",
                EmailConfirmed = true
            };


        }

        private static object GenerateAdminUser()
        {
            return new ApplicationUser()
            {
                Email = "Admin@JimmysGym.com",
                UserName = "Admin@JimmysGym.com",
                FirstName = "Admin",
                LastName = "Admins",
                EmailConfirmed = true
            };
        }

        private static async Task GenerateRoles(string[] memberRoles)
        {
            foreach (var Members in memberRoles)
                await _roleManager.CreateAsync(new IdentityRole() { Name = Members });
        }

        private static IEnumerable<GymClass> GenerateGymClasses()
        {
            throw new NotImplementedException();
        }
    }
}
