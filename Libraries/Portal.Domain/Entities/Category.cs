using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities
{
   public class Category:BaseEntity
    {
        public string MetaTitle { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public Category Parent { get; set; }
    }
}
