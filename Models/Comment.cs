using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Comment
    {
        public Comment(int commentId, int fkIssueId, string description, DateTime created)
        {
            CommentId = commentId;
            FkIssueId = fkIssueId;
            Description = description;
            Created = created;
        }

        public int CommentId { get; set; }
        
        public int FkIssueId { get; set; }
        
        public string Description { get; set; }
        
        public DateTime Created { get; set; }
    }
}
