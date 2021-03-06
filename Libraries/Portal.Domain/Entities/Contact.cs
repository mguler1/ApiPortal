﻿using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities
{
 public class Contact:BaseEntity
    {
        public int? UserId { get; set; }
        public virtual  User User { get; set; }
        public string FullaName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdrdess { get; set; }
        public string Content { get; set; }
    }

}
