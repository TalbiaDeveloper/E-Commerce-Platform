using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Platform.Models
{
    public class Cart
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } // FK to ApplicationUser (if using Identity)

        public ICollection<CartItem> CartItems { get; set; } // Navigation property
    }


}
