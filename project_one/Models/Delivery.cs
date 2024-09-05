namespace project_one.Models
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public int OrderId { get; set; }
        public int DrivertId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string? DeliveryStatus { get; set; }
    }
}
