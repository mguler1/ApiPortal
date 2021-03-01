using Portal.Domain.Entities;

namespace Portal.Infastructure.Persitence.Configuration.Polls
{
    public class PollVotingRecord
    {
        public int PollAnswerId { get; set; }

        public virtual PollAnswer PollAnswer { get; set; }

        public int PollId { get; set; }

        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}