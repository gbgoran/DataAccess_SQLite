using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Issue
    {

        public Issue()
        {
            
        }

        public Issue(int issueId, int customerId, string title, string description, string created /*, Customer customer*/) 
        {
            IssueId = issueId;
            CustomerId = customerId;
            Title = title;
            Description = description;
            Created = created;
            // customer = customer;
        }

        public int IssueId { get; set; }

        
        public int CustomerId { get; set; }


        public string Title { get; set; }


        public string Description { get; set; }

        public string Created { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
