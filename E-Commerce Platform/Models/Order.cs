using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Platform.Models
{
    public class Order
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } // FK to the ApplicationUser if using Identity

        public DateTime OrderDate { get; set; }

        [Range(0, double.MaxValue)]
        public decimal TotalAmount { get; set; }

        public string Status { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } // Navigation property
    }


}
