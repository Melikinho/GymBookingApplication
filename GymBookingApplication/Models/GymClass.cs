namespace GymBookingApplication.Models
{

    public class GymClass
#nullable disable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime EndTime { get { return StartTime + Duration; } }     /// Observera ; efter 'Duration'
        public String Description { get; set; }
    }
}
