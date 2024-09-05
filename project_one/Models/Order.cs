namespace project_one.Models
{
    public class Order
    {
        public int OrserId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string? DeliveryAddress { get; set; }
        public decimal TotalAmount { get; set; }
        public  string? Status { get; set; }
    }
}
