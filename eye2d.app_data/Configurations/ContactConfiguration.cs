using eye2d.app_data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Email).IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.PhoneNumber).IsRequired();
            builder.Property(x => x.Message).HasMaxLength(500);
            builder.Property(x => x.Status);

        }
    }
}
