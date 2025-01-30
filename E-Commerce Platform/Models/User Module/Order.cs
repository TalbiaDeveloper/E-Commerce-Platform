using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Platform.Models.User_Module
{
    public class Order
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [ForeignKey("ApplicationUser")] // Foreign Key
        public string UserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; } // Navigation property

        public DateTime OrderDate { get; set; }

        [Range(0, double.MaxValue)]
        public decimal TotalAmount { get; set; }

        public string Status { get; set; } // (e.g., Pending, Shipped, Completed)

        public ICollection<OrderItem> OrderItems { get; set; } // Navigation property
    }

}
