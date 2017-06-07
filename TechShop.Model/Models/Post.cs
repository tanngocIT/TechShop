﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TechShop.Model.Abstract;

namespace TechShop.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(250)]
        public string Name { set; get; }

        [Column(TypeName = "varchar")]
        [Required]
        [MaxLength(250)]
        public string Alias { set; get; }

        [Required]
        public int CategoryID { set; get; }

        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategories { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        [MaxLength(500)]
        public string Image { set; get; }

        public string Content { set; get; }

        public bool? HomeFlag { set; get; }

        public bool? HotFlag { set; get; }

        public int? ViewCount { set; get; }

        public virtual IEnumerable<PostTag> PostTags { set; get; }
    }
}