using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Platform.Models
{
    public class Product
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public string ImageUrl { get; set; }

        [ForeignKey("Category")] // Foreign Key
        public int CategoryId { get; set; }

        public Category Category { get; set; } // Navigation property
    }


}
