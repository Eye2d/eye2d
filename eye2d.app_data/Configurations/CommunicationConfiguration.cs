using eye2d.app_data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Configurations
{
    public class CommunicationConfiguration : IEntityTypeConfiguration<Communication>
    {
        public void Configure(EntityTypeBuilder<Communication> builder)
        {
            builder.ToTable("Communications");
            builder.Property(x => x.Id);
            builder.Property(x => x.UserId);
            builder.Property(x => x.Chat);
            builder.Property(x => x.Video);
            builder.Property(x => x.CommnucationStatus);
        }
    }
}
