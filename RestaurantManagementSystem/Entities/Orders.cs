using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public string TotalOrder { get; set; }
        public int OrderNumbers { get; set; }
        public int TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
