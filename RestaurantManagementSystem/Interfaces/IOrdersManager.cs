using RestaurantManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Interfaces
{
    public interface IOrdersManager
    {
        public Task<IEnumerable<Orders>> GetOrdersDetail();
    }
}
