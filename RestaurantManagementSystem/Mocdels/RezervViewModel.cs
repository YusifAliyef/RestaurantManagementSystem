using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Mocdels
{
    public class RezervViewModel
    {
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public DateTime RezervTime { get; set; }
    }
}
