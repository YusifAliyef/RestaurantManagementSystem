using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Entities;
using RestaurantManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Managers
{
    public class OrdersManager : GenericManager<Orders>, IOrdersManager
    {
        public async Task<IEnumerable<Orders>> GetOrdersDetail()
        {
            return await _context.Orders.ToListAsync();
        }
    }
}
