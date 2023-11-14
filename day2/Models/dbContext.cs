using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace day2.Models
{
    public class dbContext:DbContext
    {
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Catalog> Catalog { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.\\SQLEXPRESS;Database=Anas;Integrated Security=True;TrustServerCertificate=True");
        }
      
    }
}
