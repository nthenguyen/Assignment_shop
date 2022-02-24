using Microsoft.EntityFrameworkCore;
using RookieShop.Data.Configurations;
using RookieShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieShop.Data.EF
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
        }
        
        public DbSet<Category> Categories { get; set; }

        public DbSet<AppConfig> AppConfigs { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductInCategory> ProductInCategories { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
