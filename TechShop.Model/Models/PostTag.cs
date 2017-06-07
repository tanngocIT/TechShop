﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string TagID { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tags { set; get; }

        [Key]
        public int PostID { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Posts { set; get; }
    }
}