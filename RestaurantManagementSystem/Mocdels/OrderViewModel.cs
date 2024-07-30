using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Mocdels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string OrderName { get; set; }
        public int OrderNumber { get; set; }
        public int OrderPrice { get; set; }
    }
}
