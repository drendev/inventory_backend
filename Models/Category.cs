using System.ComponentModel.DataAnnotations;

namespace inventory_backend.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; } = string.Empty;

        public ICollection<Items> Items { get; set; }
    }
}
