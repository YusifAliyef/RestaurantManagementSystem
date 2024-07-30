using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Entities
{
    public class Rezervation
    {
        public int Id { get; set; }
        public DateTime RezervTime { get; set; }
        public int TableNumber { get; set; }
        public Customer Customer { get; set; }
    }
}
