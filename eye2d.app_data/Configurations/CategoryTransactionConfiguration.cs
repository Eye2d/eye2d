using eye2d.app_data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Configurations
{
    public class CategoryTransactionConfiguration : IEntityTypeConfiguration<CategoryTransaction>
    {
        public void Configure(EntityTypeBuilder<CategoryTransaction> builder)
        {
            builder.ToTable("CategoriesTransactions");
            builder.HasKey(x => new { x.CategoryId, x.LanguageId });
            builder.HasOne(x => x.Category).WithMany(pc => pc.ProductInCategories).HasForeignKey(pc => pc.CategoryId);
            builder.HasOne(x => x.Language).WithMany(pc => pc.Languages).HasForeignKey(pc => pc.LanguageId);
        }
    }
}
