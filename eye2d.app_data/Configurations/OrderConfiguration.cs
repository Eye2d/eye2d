using eye2d.app_data.Entities;
using eye2d.app_data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.Property(x => x.Id);
            builder.Property(x => x.Userid);
            builder.Property(x => x.OrderDate).IsRequired();
            builder.Property(x => x.ShipName).IsRequired();
            builder.Property(x => x.ShipAddress).IsRequired();
            builder.Property(x => x.ShipEmail).IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.ShipPhoneNumber).IsRequired();
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(OrderStatus.active);
        }
    }
}
