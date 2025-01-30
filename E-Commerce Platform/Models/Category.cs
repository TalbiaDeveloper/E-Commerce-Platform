using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Platform.Models
{
    public class Category
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Product> Products { get; set; } // Navigation property
    }


}
