using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infastructure.Persitence.Configuration.Courses
{
    public class CourseLessonConfiguration : IEntityTypeConfiguration<CourseLesson>
    {
        public void Configure(EntityTypeBuilder<CourseLesson> builder)
        {
            builder.Property(s => s.Name).IsRequired().HasMaxLength((int)MaxLenghtSize.Name);
            builder.Property(s => s.Description).IsRequired().HasMaxLength((int)MaxLenghtSize.Description);
            builder.Property(s => s.ShortDescription).IsRequired().HasMaxLength((int)MaxLenghtSize.ShortDescription);
        }
    }
}
