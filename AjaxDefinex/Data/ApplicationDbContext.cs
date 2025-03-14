using AjaxDefinex.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace AjaxDefinex.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Elektronik" },
                new Category { Id = 2, Name = "Mobilya" },
                new Category { Id = 3, Name = "Giyim" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Price = 12000, CategoryId = 1 },
                new Product { Id = 2, Name = "Telefon", Price = 8000, CategoryId = 1 },
                new Product { Id = 3, Name = "Kulaklık", Price = 1500, CategoryId = 1 },
                new Product { Id = 4, Name = "Masa", Price = 3000, CategoryId = 2 },
                new Product { Id = 5, Name = "Sandalye", Price = 1200, CategoryId = 2 },
                new Product { Id = 6, Name = "Koltuk", Price = 5000, CategoryId = 2 },
                new Product { Id = 7, Name = "Gömlek", Price = 500, CategoryId = 3 },
                new Product { Id = 8, Name = "Pantolon", Price = 600, CategoryId = 3 }
            );
        }
    }
}
