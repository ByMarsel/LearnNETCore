using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
   public class Tag
    {
        public Guid TagId { get;  }
        public Guid PostId { get; }
        public string TagName { get; }

        public Tag(Guid tagId, Guid postId, string tagName)
        {
            TagId = tagId;
            PostId = postId;
            TagName = tagName;
        }
    }
}
