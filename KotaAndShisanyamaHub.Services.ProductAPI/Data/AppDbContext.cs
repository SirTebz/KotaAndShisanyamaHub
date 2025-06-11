using KotaAndShisanyamaHub.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace KotaAndShisanyamaHub.Services.ProductAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Shisanyama Plater",
                Price = 85,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer feugiat, mauris ut faucibus rhoncus, tellus orci blandit libero, a fermentum sem diam sagittis lacus. Proin.",
                ImageUrl = "https://placehold.co/603x403",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Regular Platter",
                Price = 69.99,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer feugiat, mauris ut faucibus rhoncus, tellus orci blandit libero, a fermentum sem diam sagittis lacus. Proin.",
                ImageUrl = "https://placehold.co/602x402",
                CategoryName = "Entre"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "BunnyChow Latte",
                Price = 109.99,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer feugiat, mauris ut faucibus rhoncus, tellus orci blandit libero, a fermentum sem diam sagittis lacus. Proin.",
                ImageUrl = "https://placehold.co/601x401",
                CategoryName = "Meal"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Sweet Pie",
                Price = 65,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer feugiat, mauris ut faucibus rhoncus, tellus orci blandit libero, a fermentum sem diam sagittis lacus. Proin.",
                ImageUrl = "https://placehold.co/600x400",
                CategoryName = "Dessert"
            });
        }
    }
    
}
