using eye2d.app_data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using TransactionStatus = eye2d.app_data.Enums.TransactionStatus;

namespace eye2d.app_data.Configurations
{
    class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TransactionDate).IsRequired();
            builder.Property(x => x.Amount).IsRequired().HasDefaultValue<int>(0);
            builder.Property(x => x.ShippingFee).IsRequired().HasDefaultValue<int>(0);
            builder.Property(x => x.Result).IsRequired;
            builder.Property(x => x.Provider).IsRequired;
            builder.Property(x => x.TransactionStatus).IsRequired().HasDefaultValue(TransactionStatus.active);
        }
    }
}
