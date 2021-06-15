using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Models
{
    public class NutritionProduct
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Weight { get; set; }
        public int Quantity { get; set; }
        public string Brand { get; set; }

    }
}
