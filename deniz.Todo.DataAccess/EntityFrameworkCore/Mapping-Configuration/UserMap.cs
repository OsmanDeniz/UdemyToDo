using System;
using System.Collections.Generic;
using System.Text;
using deniz.Todo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace deniz.Todo.DataAccess.EntityFrameworkCore.Mapping_Configuration
{
    class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.Property(I => I.Firstname).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Lastname).HasMaxLength(100).IsRequired(false);
            builder.Property(I => I.Phone).HasMaxLength(50).IsRequired();
            builder.Property(I => I.Email).HasMaxLength(100).IsRequired();

            builder.HasMany(I => I.WorkList).WithOne(I => I.User).HasForeignKey(I => I.UserId);

        }
    }
}
