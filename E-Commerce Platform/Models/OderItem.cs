using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Platform.Models
{
    public class OrderItem
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [ForeignKey("Order")] // Foreign Key
        public int OrderId { get; set; }

        public Order Order { get; set; } // Navigation property

        [ForeignKey("Product")] // Foreign Key
        public int ProductId { get; set; }

        public Product Product { get; set; } // Navigation property

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
    }


}
