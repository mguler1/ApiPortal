using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Portal.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;

namespace Portal.Infastructure.Persitence.Configurations.Contents
{
    public class ContentConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(s => s.FullaName).IsRequired().HasMaxLength((int)MaxLenghtSize.Name);
            builder.Property(s => s.EmailAdrdess).IsRequired().HasMaxLength((int)MaxLenghtSize.EmailAddress);
            builder.Property(s => s.PhoneNumber).IsRequired().HasMaxLength((int)MaxLenghtSize.PhoneNumber);
            builder.Property(s => s.Content).IsRequired().HasMaxLength((int)MaxLenghtSize.Description);

        }
    }
}
