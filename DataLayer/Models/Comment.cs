using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
   public class Comment
    {
       public string Author { get; }
       public string Body { get;  }
       public Guid CommentId { get; }
       public DateTime CreateDate { get;  }
       public Guid PostId { get;  }

        public Comment(string author, string body, Guid commentId, DateTime createDate, Guid postId)
        {
            Author = author;
            Body = body;
            CommentId = commentId;
            CreateDate = createDate;
            PostId = postId;
        }
    }
}
