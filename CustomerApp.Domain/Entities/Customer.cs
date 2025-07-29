using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Entities

{
    public class Customer
    {
        public int CustomerId { get; set; } // Sesuai dengan customerld SERIAL PRIMARY KEY [cite: 11]
        public string CustomerCode { get; set; } // [cite: 12]
        public string CustomerName { get; set; } // [cite: 13]
        public string CustomerAddress { get; set; } // [cite: 14]
        public int CreatedBy { get; set; } // [cite: 15]
        public DateTime CreatedAt { get; set; } // [cite: 16]
        public int? ModifiedBy { get; set; } // Nullable [cite: 17]
        public DateTime? ModifiedAt { get; set; } // Nullable [cite: 18]
    }
}
