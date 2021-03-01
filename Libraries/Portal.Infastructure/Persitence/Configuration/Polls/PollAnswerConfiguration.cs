using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Common;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infastructure.Persitence.Configuration.Polls
{
    public class PollAnswerConfiguration : IEntityTypeConfiguration<PollAnswer>
    {
        public void Configure(EntityTypeBuilder<PollAnswer> builder)
    {
        builder.Property(s => s.Name).IsRequired().HasMaxLength((int)MaxLenghtSize.Name);
        builder.Property(s => s.PollId).IsRequired();
    }
}
}
