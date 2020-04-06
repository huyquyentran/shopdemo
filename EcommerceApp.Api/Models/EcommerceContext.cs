using EcommerceApp.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApp.Api.Models
{

    public class EcommerceContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public EcommerceContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(category =>
            {
                category.ToTable("categories");
                category.Property(c => c.Id).ValueGeneratedOnAdd().UseMySqlIdentityColumn();
                category.Property(c => c.Name).IsRequired();
            });

            modelBuilder.Entity<Product>(product =>
            {
                product.ToTable("products");
                product.Property(p => p.Id).ValueGeneratedOnAdd().UseMySqlIdentityColumn();
                product.Property(p => p.Name).IsRequired();
                product.Property(p => p.Price).IsRequired();
                product.Property(p => p.Image).IsRequired();
                product.Property(p => p.Origin).IsRequired();
                product.Property(p => p.CategoryId).IsRequired();
            });

            // Seed
            modelBuilder.Seed();
        }
    }
}