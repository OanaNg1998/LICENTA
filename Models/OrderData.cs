using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Models
{
    public class OrderData
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<OrderProduct> Products { get; set; }
     
    }
}
