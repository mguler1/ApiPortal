using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities
{
    public class Poll:BaseEntity
    {
        public string  Name { get; set; }
        public bool  ShowOnHomePage { get; set; }
        public bool  AllowGuetsToVote { get; set; }
        public DateTime  StartDate { get; set; }
        public DateTime?  EndDate { get; set; }
    }
}
