using Microsoft.EntityFrameworkCore;
using week11_BlazorEF.Models;

namespace week11_BlazorEF.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id=1,Name="Laptop",Price=800},
                new Product { Id=2,Name="Phone",Price=600},
                new Product { Id=3,Name="Tablet",Price=400}

                );
        }
    }
}
