namespace GymBookingApplication.Models
{
    public class ApplicationUserGymClass
#nullable disable
    {
        public int Id { get; set; }
        public int GymClassId { get; set; } 
        public GymClass GymClass { get; set; }

    }
}
