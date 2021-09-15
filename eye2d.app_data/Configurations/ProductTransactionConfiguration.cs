using eye2d.app_data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Configurations
{
    public class ProductTransactionConfiguration : IEntityTypeConfigutation<ProductTransaction>
    {
        public void Configure(EntityTypeBuilder<ProductTransaction> builder)
        {
            builder.ToTable("ProductTransactions");
            builder.HasKey(x => new { x.ProductId, x.LanguageId });
            builder.HasOne(x => x.Product).WithMany(pc => pc.ProductInCategories).HasForeignKey(pc => pc.ProductId);
            builder.HasOne(x => x.Language).WithMany(pc => pc.Languages).HasForeignKey(pc => pc.LanguageId);
        }
}
