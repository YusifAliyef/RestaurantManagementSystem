using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using RestaurantManagementSystem.Contexts;
using RestaurantManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Managers
{
    public class GenericManager<T> : IGenericManager<T> where T : class, new()
    {
        public DbSet<T>Entity { get; set; }
        protected readonly RestaurantContext _context;
        public GenericManager()
        {
            _context = new RestaurantContext();
            Entity=_context.Set<T>();   
        }

        public async Task AddAcync(T entity)
        {
           await Entity.AddAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await Entity.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await Entity.FindAsync(id);
        }

        public void Remove(T entity)
        {
           Entity.Remove(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
          Entity.Update(entity);
        }
    }
}
