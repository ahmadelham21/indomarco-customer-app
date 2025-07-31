using CustomerApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        Task AddCustomer(Customer customer);
        Task<IEnumerable<Customer>?> FindAllCustomer();

        Task<Customer> GetByIdCustomer(int id);

        Task UpdateCustomer(Customer customer);
        Task DeleteCustomerById(Customer customer);

        Task<bool> CustomerIdIsExist(int customerId);
    }
}
