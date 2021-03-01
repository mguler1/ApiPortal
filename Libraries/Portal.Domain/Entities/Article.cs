using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities
{
    public class Article:BaseEntity
    {
        public string Tİtle { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int? ThumbnailImageId { get; set; }
        public virtual Media ThumbnailImage { get; set; }
        public int ReviewsCount { get; set; }

    }
}
