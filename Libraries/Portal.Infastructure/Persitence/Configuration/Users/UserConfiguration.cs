using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infastructure.Persitence.Configurations.Users
{
   public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(s => s.FullName).IsRequired().HasMaxLength((int)MaxLenghtSize.Name);
            builder.Property(s => s.Email).IsRequired().HasMaxLength((int)MaxLenghtSize.EmailAddress);
            builder.HasIndex(s => s.Email).IsUnique();

        }
    }
}
