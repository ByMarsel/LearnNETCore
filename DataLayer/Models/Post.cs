using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
   public class Post
    {
        public string Body { get; }
        public string Comments { get; }
        public DateTime CreatedDate { get; }
        public string Header { get; }
        public Guid PostId { get; }
        public List<Tag> Tags { get; }

        public Post(string body, string comments, DateTime createdDate, string header, Guid postId, List<Tag> tags)
        {
            Body = body;
            Comments = comments;
            CreatedDate = createdDate;
            Header = header;
            PostId = postId;
            Tags = tags;
        }
    }
}
