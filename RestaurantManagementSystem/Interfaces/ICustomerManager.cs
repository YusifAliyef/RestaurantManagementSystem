using RestaurantManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Interfaces
{
    public interface ICustomerManager
    {
        public Task AddAsync(Customer entity);
        public void Update(Customer entity);
        public void Remove(Customer entity);
        public Task<IEnumerable<Customer>> GetAllAsync();
        public Task<Customer> GetById(int id);
        public Task SaveChangesAsync();
        public Task<IEnumerable<Customer>> GetCustomerDetail();

    }
}