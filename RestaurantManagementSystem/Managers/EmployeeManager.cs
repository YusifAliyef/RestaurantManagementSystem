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
    public class EmployeeManager : GenericManager<Employee>, IEmployeeManager
    {
        public async Task<IEnumerable<Employee>> GetEmpDetail()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
