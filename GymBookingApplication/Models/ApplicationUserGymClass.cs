namespace GymBookingApplication.Models
{
    public class ApplicationUserGymClass
#nullable disable
    {
        public int GymClassId { get; set; }   //Foreign
        public int ApplicationUserId { get; set; }  //Foreign
        public GymClass GymClass { get; set; }   //Nav
        public ApplicationUser applicationUser { get; set; }  //Nav

    }
}
