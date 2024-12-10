using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_NookDataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_NookDataAccess.Data
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
                new Category{ Id = 1001, Name = "Action", DisplayOrder = 1 },
                new Category{ Id = 1002, Name = "Science Fiction", DisplayOrder = 2 },
                new Category{ Id = 1003, Name = "Fantasy", DisplayOrder = 3 },
                new Category{ Id = 1004, Name = "Classic", DisplayOrder = 4 }
            );
        }
    }
}