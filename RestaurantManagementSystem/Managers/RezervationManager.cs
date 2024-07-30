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
    public class RezervationManager : GenericManager<Rezervation>, IRezervationManager
    {

        public async Task<IEnumerable<Rezervation>> GetRezervdetail()
        {
            return await _context.Rezervations.ToListAsync();
        }
    }
}
