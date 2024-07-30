using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Contexts;
using RestaurantManagementSystem.Entities;
using RestaurantManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Managers
{
    public class CustomerManager : ICustomerManager
    {
        protected readonly RestaurantContext _context;

        public CustomerManager()
        {
            _context = new RestaurantContext();
        }

        public async Task AddAsync(Customer entity)
        {
           await _context.AddAsync(entity);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetById(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task<IEnumerable<Customer>> GetCustomerDetail()
        {
            return await _context.Customers.ToListAsync();
        }

    

        public void Remove(Customer entity)
        {
          _context.Customers.Remove(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(Customer entity)
        {
           _context.Customers.Update(entity);
        }
    }
}
