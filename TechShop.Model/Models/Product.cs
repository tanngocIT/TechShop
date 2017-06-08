using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using TechShop.Model.Abstract;

namespace TechShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Column(TypeName = "varchar")]
        [Required]
        [MaxLength(250)]
        public string Name { set; get; }

        [Required]
        [MaxLength(250)]
        public string Alias { set; get; }

        [Required]
        public int CategoryID { set; get; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategies { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        [MaxLength(500)]
        public string Image { set; get; }

        [Column(TypeName ="xml")]
        public string MoreImage { set; get; }

        public int Quantity { set; get; }

        [Required]
        public decimal Price { set; get; }

        public decimal? PromotionPrice { set; get; }

        public int? Waranty { set; get; }

        public string Content { set; get; }

        public bool? HomeFlag { set; get; }

        public bool? HotFlag { set; get; }

        public int? ViewCount { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }

        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}