using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infastructure.Persitence.Configurations.Categories
{
    public class UserConfiguration : IEntityTypeConfiguration<Category>
    {
      
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(s => s.Name).IsRequired().HasMaxLength((int)MaxLenghtSize.Name);
            builder.Property(s => s.Description).IsRequired().HasMaxLength((int)MaxLenghtSize.Description);
            builder.Property(s => s.MetaTitle).IsRequired().HasMaxLength((int)MaxLenghtSize.Metatitle);
            builder.Property(s => s.MetaDescription).IsRequired().HasMaxLength((int)MaxLenghtSize.MetaDescription);
            builder.Property(s => s.MetaKeyword).IsRequired().HasMaxLength((int)MaxLenghtSize.MetaDescription);
            builder.HasIndex(s => s.Name).IsUnique();
        }
    }
}
