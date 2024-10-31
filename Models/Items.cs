using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inventory_backend.Models
{
    public class Items
    {
        [Key]
        public Guid ItemId { get; set; } = Guid.NewGuid();

        [Required]
        public string ItemName { get; set; } = String.Empty;

        [Required]
        public string ItemImage { get; set; } = String.Empty;

        public int ItemQuantity { get; set; } = 0;

        [Required]
        public int BuyingPrice { get; set; } = 0;

        [Required]
        public int SellingPrice { get; set; } = 0;

        [Required] 
        public string ItemDescription { get; set; } = String.Empty;

        public int ItemScanned { get; set; } = 0;

        [Required]
        public DateOnly? ItemExpiryDate { get; set; }

        [Required]
        public DateOnly? ItemManufactureDate { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
