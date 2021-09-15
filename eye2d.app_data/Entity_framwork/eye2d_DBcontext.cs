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
            modelBuilder.ApplyConfiguration(new AppConfigConfiguratation());
            modelBuilder.ApplyConfiguration(new ProductConfiguratation());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguratation());
            modelBuilder.ApplyConfiguration(new OrderConfiguratation());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguratation());
            modelBuilder.ApplyConfiguration(new TransactionConfiguratation());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguratation());
            modelBuilder.ApplyConfiguration(new ContactConfiguratation());
            modelBuilder.ApplyConfiguration(new LanguageConfiguratation());
            modelBuilder.ApplyConfiguration(new ProductTransactionConfiguratation());
            // Configure Code First to ignore PluralizingTableName convention
            // If you keep this convention then the generated tables will have pluralized names.
            // base.OnModelCreating(ModuleBuilder);
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppConfig> Configurations { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductTransaction> ProductTransactions { get; set; }
        public DbSet<CategoryTransaction> CategoriesTransactions { get; set; }
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
