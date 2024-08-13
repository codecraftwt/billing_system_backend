using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace billing_system.Models
{
    public class OrdersModel
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("FoodItem")]
        public int FoodItemId { get; set; }

        [ForeignKey("PaymentMethod")]
        public int PaymentMethodId { get; set; }

        [ForeignKey("DiningTable")]
        public int TableId { get; set; }

        [StringLength(50)]
        public string? CustomerName { get; set; }

        [StringLength(50)]
        public string? CustomerMobile { get; set; }

        [StringLength(50)]
        public string? SubTotal { get; set; }

        [StringLength(50)]
        public string? Discount { get; set; }

        [StringLength(50)]
        public string? GST { get; set; }

        [StringLength(50)]
        public string? Total { get; set; }

        [StringLength(50)]
        public string? PaidAmount { get; set; }

        [StringLength(50)]
        public string? RmngAmount { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        //public virtual FoodItem FoodItem { get; set; }
        //public virtual PaymentMethod PaymentMethod { get; set; }
        //public virtual DiningTable DiningTable { get; set; }
    }
}
