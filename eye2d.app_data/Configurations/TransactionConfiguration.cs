using eye2d.app_data.Entities;
using eye2d.app_data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TransactionDate).IsRequired();
            builder.Property(x => x.Amount).IsRequired().HasDefaultValue<int>(0);
            builder.Property(x => x.ShippingFee).IsRequired().HasDefaultValue<int>(0);
            builder.Property(x => x.Result).IsRequired();
            builder.Property(x => x.Provider).IsRequired();
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(TransactionStatus.active);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.AppUser).WithMany(x => x.Transactions).HasForeignKey(x => x.UserId);
        }
    }
}
