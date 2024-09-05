using System.ComponentModel.DataAnnotations;

namespace project_one.Models
{
    public class Customer
    {

        public int CustomerId { get; set; }
        [Required]
        public string? CustomerName { get; set; }
        [Required]
        [EmailAddress]
        public string? CustomerEmail { get; set; }
        [Required]
        public string? CustomerPhone { get; set; }
        [Required]
        public string? CustomerAddress { get; set; }
    }
}
