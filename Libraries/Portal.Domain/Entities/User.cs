using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities
{
    public class User:BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
       public virtual ICollection<Article> Articles { get; set; }//kullanıcının birden fazla makalesi olabilir
       public virtual ICollection<Comment> Comments { get; set; }//kullanıcının birden fazla yorumu olabilir
       public virtual ICollection<Contact> Contacts { get; set; }//
       public virtual ICollection<CourseLesson> CourseLessons { get; set; }//
       public virtual ICollection<PollVotitngRecord> PollVotitngRecords { get; set; }//

    }
}
