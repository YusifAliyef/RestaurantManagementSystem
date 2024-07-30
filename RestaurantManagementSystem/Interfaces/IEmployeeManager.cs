using RestaurantManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Interfaces
{
    public interface IEmployeeManager
    {
        public Task<IEnumerable<Employee>> GetEmpDetail();
    }
}
