﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Infastructure.Persitence.Configuration.Polls
{
    public class PollVotingRecordConfiguration : IEntityTypeConfiguration<PollVotingRecord>
    {
        public void Configure(EntityTypeBuilder<PollVotingRecord> builder)
        {
            builder.Property(s =>s.PollId).IsRequired();
            builder.Property(s =>s.PollAnswerId).IsRequired();
        }
    }
}
