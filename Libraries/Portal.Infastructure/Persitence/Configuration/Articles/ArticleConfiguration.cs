using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;

namespace Portal.Infastructure.Persitence.Configurations.Articles
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(s => s.Tİtle).IsRequired().HasMaxLength((int)MaxLenghtSize.Title);
            builder.Property(s => s.ShortDescription).IsRequired().HasMaxLength((int)MaxLenghtSize.ShortDescription);
            builder.Property(s => s.Description).IsRequired().HasMaxLength((int)MaxLenghtSize.Description);
        }
    }
}
