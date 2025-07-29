using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Entities

{
    public class Customer
    {
        public int CustomerId { get; set; } 
        public string CustomerCode { get; set; } 
        public string CustomerName { get; set; } 
        public string CustomerAddress { get; set; } 
        public int CreatedBy { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public int? ModifiedBy { get; set; } 
        public DateTime? ModifiedAt { get; set; } 
    }
}
