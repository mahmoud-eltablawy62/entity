using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posts.models
{
    public class Author
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string ? Address { get; set; }
        public string? Email { get; set; }
        public string? Passwors { get; set; }
        public List<post>? posts{ get; set; }=new List<post>();
    }
}
