using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_Nook.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_Nook.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category{ Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category{ Id = 2, Name = "Science Fiction", DisplayOrder = 2 },
                new Category{ Id = 3, Name = "Fantasy", DisplayOrder = 3 }
            );
        }
    }
}