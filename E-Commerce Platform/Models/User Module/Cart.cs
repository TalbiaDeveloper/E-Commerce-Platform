using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Platform.Models.User_Module
{
    public class Cart
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [ForeignKey("ApplicationUser")] // Foreign Key
        public string UserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; } // Navigation property

        public ICollection<CartItem> CartItems { get; set; } // Navigation property
    }

}
