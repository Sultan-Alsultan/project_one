namespace project_one.Models
{
    public class OrderTracking
    {
        public int TrackingId { get; set; } 
        public int OrderId { get; set; }
        public DateTime StatusDate { get; set; }
        public string? Location { get; set; }
        public string? CurrentStatus { get; set; }
    }
}
