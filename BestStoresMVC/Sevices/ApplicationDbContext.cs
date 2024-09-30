using BestStoresMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BestStoresMVC.Sevices
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
           
        }

        public DbSet<Product> Products { get; set; }
    }
}
