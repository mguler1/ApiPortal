﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infastructure.Persitence.Configuration.Courses
{
    public class CourseActionConfiguration : IEntityTypeConfiguration<CourseAction>
    {
        public void Configure(EntityTypeBuilder<CourseAction> builder)
        {
            builder.Property(s => s.UserId).IsRequired();
            builder.Property(s => s.UserId).IsRequired();
            builder.Property(s => s.CourseLessonId  ).IsRequired();
        }
    }
}
