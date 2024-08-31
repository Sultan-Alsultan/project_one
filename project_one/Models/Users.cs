using System.ComponentModel.DataAnnotations;

namespace project_one.Models
{
    public class Users
    {
        public int Id { get; set; }
        //=======================================
        [Required]
        public string? Name { get; set; }
        //======================================
        [EmailAddress]
        public string? Email { get; set; }
        //==================================
        public int? Password { get; set; }
        //=====================================
        public string? Privlliage { get; set; }
    }
}
