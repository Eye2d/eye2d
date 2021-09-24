using eye2d.app_data.Entities;
<<<<<<< HEAD
using eye2d.app_data.Enums;
=======
>>>>>>> Feature/database_design
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
<<<<<<< HEAD
=======
using System.Transactions;
using Transaction = eye2d.app_data.Entities.Transaction;
>>>>>>> Feature/database_design

namespace eye2d.app_data.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.AppUser).WithMany(x => x.Transactions).HasForeignKey(x => x.UserId);


        }
    }
}
