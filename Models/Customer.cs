using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Customer

    {
        public Customer()
        {

        }
        
        public Customer(int customerId, string fullName, string companyName, int contactNumber)
        {
            CustomerId = customerId;
            FullName = fullName;
            CompanyName = companyName;
            ContactNumber = contactNumber;
        }

        public long CustomerId { get; set; }

        
        public string FullName { get; set; }
        
        public string CompanyName { get; set; }

        public long ContactNumber { get; set; }
    }
}
