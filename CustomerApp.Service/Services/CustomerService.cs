using CustomerApp.Domain.Entities;
using CustomerApp.Repository.Interfaces;
using CustomerApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Service.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository) { 
            this._customerRepository = customerRepository;
        }

        public async Task CreateCustomer(Customer customer)
        {
            if (await _customerRepository.CustomerIdIsExist(customer.CustomerId))
                throw new Exception("Customer already exists");

            await _customerRepository.AddCustomer(customer);
        
        }


        public async Task DeleteCustomerById(int id)
        {
            Customer customer = await _customerRepository.GetByIdCustomer(id) ?? throw new Exception("Customer Not Found");
            await _customerRepository.DeleteCustomerById(customer);
        }

        public async Task<IEnumerable<Customer>?> GetAllCustomer()
        {
            return await _customerRepository.FindAllCustomer();
        }

        public async Task<Customer> GetByIdCustomer(int id)
        {
            return await _customerRepository.GetByIdCustomer(id) ?? throw new Exception("Customer Not Found");
        }

        public async Task UpdateCustomer(Customer customer)
        {
            Customer customerToUpdate = await _customerRepository.GetByIdCustomer(customer.CustomerId) ?? throw new Exception("Customer Not Found");
            customerToUpdate.CustomerName = customer.CustomerName;
            customerToUpdate.CustomerAddress = customer.CustomerAddress;
            customerToUpdate.CustomerCode = customer.CustomerCode;
            customerToUpdate.ModifiedAt = DateTime.UtcNow;
            customerToUpdate.ModifiedBy = customer.ModifiedBy;

            await _customerRepository.UpdateCustomer(customer);
   
        }
    }
}
