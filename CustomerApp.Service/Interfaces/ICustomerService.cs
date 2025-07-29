using CustomerApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Service.Interfaces
{
    public interface ICustomerService
    {

        Task CreateCustomer(Customer customer);
        Task<IEnumerable<Customer>?> GetAllCustomer();
    }
}
