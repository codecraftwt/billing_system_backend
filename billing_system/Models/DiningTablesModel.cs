using System.ComponentModel.DataAnnotations;

namespace billing_system.Models
{
    public class DiningTablesModel
    {
        [Key]
        public int TableId { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? SeatingCapacity { get; set; }

        [Required]
        public string? Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
