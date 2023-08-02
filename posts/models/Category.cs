using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posts.models
{
    public class Category
    {
        public int Id { get; set; }
        public string ? Name { get; set; }

        public List <post> ? posts { get; set; }= new List<post>();
    }
}
