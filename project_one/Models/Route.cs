namespace project_one.Models
{
    public class Route
    {
        public int RouteId { get; set; }
        public int DeliveryId { get; set; }
        public string? StartLocation { get; set; }
        public string? EndLocation { get; set; }
        public double? Distance { get; set; }
        public DateTime TimeOfArrival { get; set; }
    }
}
