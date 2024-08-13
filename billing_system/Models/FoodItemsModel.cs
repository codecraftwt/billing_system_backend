using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace billing_system.Models
{
    public class FoodItemsModel
    {
        [Key]
        public int FoodItemId { get; set; }

        [ForeignKey("FoodCategory")]
        public int FoodCategoryId { get; set; }

        [Required]
        public string? Name { get; set; }

        public byte[]? Image { get; set; }

        public string? Price { get; set; }

        [Required]
        public string? Type { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
        //public virtual FoodItem FoodItem { get; set; }
        //public virtual PaymentMethod PaymentMethod { get; set; }
        //public virtual DiningTable DiningTable { get; set; }

    }
}
