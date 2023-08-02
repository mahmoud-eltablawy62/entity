using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posts.models
{
     public class postsContext : DbContext
    {
        public DbSet<Author> authors { get; set;}
        public DbSet <Category> categories { get; set;}
        public DbSet <post> Posts { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=posts;Trusted_Connection=True;TrustServerCertificate=true ");
        }

    }
}
