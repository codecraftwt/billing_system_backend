using System.ComponentModel.DataAnnotations;

namespace billing_system.Models
{
    public class FoodCategoriesModel
    {
        [Key]
        public int FoodCategoryId { get; set; }

        [Required]
        public string? Name { get; set; }

        public byte[]? Image { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
