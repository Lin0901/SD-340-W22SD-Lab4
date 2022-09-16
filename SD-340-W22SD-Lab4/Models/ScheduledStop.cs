namespace SD_340_W22SD_Lab4.Models
{
    public class ScheduledStop
    {
        public int Id { get; set; }
        public Stop? Stop { get; set; }
        public Route? Route { get; set; }
        public DateTime ScheduledArrival { get; set; }
    }
}
