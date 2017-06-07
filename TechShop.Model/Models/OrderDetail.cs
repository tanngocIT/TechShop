using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Orders { set; get; }

        [Key]
        public int ProductID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }

        public int Quantity { set; get; }

        public decimal Amount { set; get; }
    }
}