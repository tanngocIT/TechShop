using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [Column(Order =1)]
        public int OrderID { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Orders { set; get; }

        [Key]
        [Column(Order = 2)]
        public int ProductID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }

        public int Quantity { set; get; }

        public decimal Amount { set; get; }
    }
}