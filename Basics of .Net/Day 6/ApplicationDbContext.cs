using Day_6.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Day_6
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}