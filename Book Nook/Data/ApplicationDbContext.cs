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
    }
}