using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get;set; }

        // Category tablosu ile ilişki
        public int CategoryID { get; set; } // Foreign Key 
        public Category Category { get; set; }

        // Comment tablosu ile ilişki
        public List<Comment> Comments { get; set; }
    }
}
