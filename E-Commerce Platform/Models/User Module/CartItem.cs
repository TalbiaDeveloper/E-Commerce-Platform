using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Platform.Models.User_Module
{
    public class CartItem
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [ForeignKey("Cart")] // Foreign Key
        public int CartId { get; set; }

        public Cart Cart { get; set; } // Navigation property

        [ForeignKey("Product")] // Foreign Key
        public int ProductId { get; set; }

        public Product Product { get; set; } // Navigation property

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }

}
