using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Entities

{
    [Table("customer")]
    public class Customer
    {
        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("customer_code")]
        public string CustomerCode { get; set; }

        [Column("customer_name")]
        public string CustomerName { get; set; }

        [Column("customer_address")]
        public string CustomerAddress { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("modified_by")]
        public int? ModifiedBy { get; set; }

        [Column("modified_at")]
        public DateTime? ModifiedAt { get; set; }
    }
}
