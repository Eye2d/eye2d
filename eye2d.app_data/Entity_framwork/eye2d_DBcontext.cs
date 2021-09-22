using eye2d.app_data.Configurations;
using eye2d.app_data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Entity_framwork
{
    public class eye2d_DBcontext: DbContext
    {
        public eye2d_DBcontext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            // Configure Code First to ignore PluralizingTableName convention
            // If you keep this convention then the generated tables will have pluralized names.
            // base.OnModelCreating(ModuleBuilder);
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppConfig> Configurations { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductTranslation> ProductTransactions { get; set; }
        public DbSet<CategoryTranslation> CategoriesTransactions { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<OrderDetail> Ordetails { get; set; }
        public DbSet<SystemActivity> SystemActivities { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Language> Languages { get; set; }
    }

    internal class OrderDetailConfiguratation
    {
        public OrderDetailConfiguratation()
        {
        }
    }

    internal class OrderConfiguratation
    {
        public OrderConfiguratation()
        {
        }
    }

    internal class CartConfiguratation
    {
        public CartConfiguratation()
        {
        }
    }

    internal class ProductConfiguratation
    {
        public ProductConfiguratation()
        {
        }
    }
}
