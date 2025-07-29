using CustomerApp.Domain.Entities;
using CustomerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Repository.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer getData()
        {
            Customer customer = new Customer();
            customer.CustomerName = "Ahmad Ilham";

            return customer;
        }
    }
}
