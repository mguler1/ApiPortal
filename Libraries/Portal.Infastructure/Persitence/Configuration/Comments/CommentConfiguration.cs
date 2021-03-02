using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infastructure.Persitence.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(s => s.ArticleId).IsRequired().HasMaxLength((int)MaxLenghtSize.Name);
            builder.Property(s => s.CommentText).IsRequired().HasMaxLength((int)MaxLenghtSize.Description);
            builder.Property(s => s.CommenterName).IsRequired().HasMaxLength((int)MaxLenghtSize.EmailAddress);
            builder.Property(s => s.CommenterEmail).IsRequired().HasMaxLength((int)MaxLenghtSize.EmailAddress);

        }
    }
}
