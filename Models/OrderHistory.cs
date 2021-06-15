using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Models
{
    public class OrderHistory
    {
        public string Id { get; set; }
        public string OrderId { get; set; }
        public string EquipmentId { get; set; }
        public string CompleteName { get; set; }
        public string EmailAddress { get; set; }
        public string ProductNumber { get; set; }
        public int TotalPrice { get; set; }
        public string DeliveryAddress { get; set; }
        public string ProductQuantity { get; set; }
        

        public virtual ICollection<Equipment> Equipment { get; set; }
        public virtual ICollection<NutritionProduct> NutritionProduct { get; set; }



    }
}
