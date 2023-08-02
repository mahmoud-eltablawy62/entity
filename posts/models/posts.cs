using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posts.models
{
    public class post
    {
        public int id { get; set; }
        public string ? title { get; set; }
        public string ? description { get; set; }
        
      
        public int? category_id { get; set; }
        public int? author_id { get; set; }
        public Author? author { get; set; }
        public Category ? category { get; set; } 


    }
}
