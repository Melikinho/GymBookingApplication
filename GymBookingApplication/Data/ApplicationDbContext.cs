using GymBookingApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GymBookingApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
#nullable disable
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GymBookingApplication.Models.GymClass> GymClass => Set<GymClass>();
        public DbSet<GymBookingApplication.Models.ApplicationUser> ApplicationUser { get; set; } = null!;
    }
}