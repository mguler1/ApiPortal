using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infastructure.Persitence.Configuration.Courses
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(s => s.Name).IsRequired().HasMaxLength((int)MaxLenghtSize.Name);
            builder.Property(s => s.Description).IsRequired().HasMaxLength((int)MaxLenghtSize.Description);
            builder.Property(s => s.ShortDescription).IsRequired().HasMaxLength((int)MaxLenghtSize.ShortDescription);
            builder.Property(s =>s.MetaTitle).IsRequired().HasMaxLength((int)MaxLenghtSize.Metatitle);
            builder.Property(s => s.MetaDescription).IsRequired().HasMaxLength((int)MaxLenghtSize.MetaDescription);
            builder.Property(s => s.MetaKeyword).IsRequired().HasMaxLength((int)MaxLenghtSize.MetaDescription);

        }
    }
}
