using System.ComponentModel.DataAnnotations;

namespace billing_system.Models
{
    public class PayementMethodsModel
    {
        [Key]
        public int PaymentMethodId { get; set; }

        [Required]
        public string? PaymentMethodName { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
