using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace inventory_backend.Controllers
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public DateTime? Birthday { get; set; }

        [Required]
        public string FullName { get; set; } = String.Empty;

        [Required]
        public string Role { get; set; } = String.Empty;
    }
}
