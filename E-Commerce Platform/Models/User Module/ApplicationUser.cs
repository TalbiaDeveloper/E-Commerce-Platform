using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Platform.Models.User_Module
{
    public class ApplicationUser : IdentityUser
    {
        [Key] // Primary Key
        public string Id { get; set; } // PK inherited from IdentityUser

        public string? FullName { get; set; } // Additional user information

        public ICollection<Order>? Orders { get; set; } // Navigation property for Orders
    }

}
