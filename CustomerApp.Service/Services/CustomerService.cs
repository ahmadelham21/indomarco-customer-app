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

        public object getData()
        {
           return _customerRepository.getData();
        }
    }
}
