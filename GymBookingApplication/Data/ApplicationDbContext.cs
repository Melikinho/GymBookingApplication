using GymBookingApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GymBookingApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
#nullable disable
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GymBookingApplication.Models.GymClass> GymClass => Set<GymClass>();
        public DbSet<GymBookingApplication.Models.ApplicationUser> ApplicationUser { get; set; } = null!;

        public DbSet<GymBookingApplication.Models.ApplicationUserGymClass> ApplicationUserGymClass => Set<ApplicationUserGymClass>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
                .HasMany(m => m.GymClasses)
                .WithMany(n => n.ApplicationUsers)
                .UsingEntity<ApplicationUserGymClass>(
                Ha => Ha.HasOne(Ha => Ha.GymClass).WithMany(m => m.ApplicationUserGymClasses),
                Ha => Ha.HasOne(Ha => Ha.ApplicationUser).WithMany(m => m.ApplicationUserGymClasses));

            //KompositNyckel - Fluent API

            builder.Entity<ApplicationUserGymClass>().HasKey(
                a => new { a.ApplicationUserId, a.GymClassId });
        }
    }
}