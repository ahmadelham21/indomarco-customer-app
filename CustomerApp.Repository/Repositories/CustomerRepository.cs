using CustomerApp.Domain.Entities;
using CustomerApp.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Repository.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }

        public async Task AddCustomer(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>?> FindAllCustomer()
        {
           return await _context.Customers.ToListAsync();
        }

       

        public async Task DeleteCustomerById(Customer customer)
        {
            
            _context.Customers.Remove(customer);


            await _context.SaveChangesAsync();
        }

      

        public async Task<Customer> GetByIdCustomer(int id)
        {
            Customer? customer = await _context.Customers.FindAsync(id);
            return customer;
        }

        public async Task UpdateCustomer(Customer customer)
        {


            _context.Entry(customer).State = EntityState.Modified;


            await _context.SaveChangesAsync();

        }


        public async Task<bool> CustomerIdIsExist(int customerId)
        {
            return await _context.Customers
                .AnyAsync(c => c.CustomerId == customerId);
        }
    }
}
