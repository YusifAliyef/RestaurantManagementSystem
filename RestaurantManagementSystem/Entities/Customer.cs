using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RezervationId { get; set; }
        public Rezervation Rezervation { get; set; }
  
        public ICollection<Orders>Orders { get; set; }
    }
}
