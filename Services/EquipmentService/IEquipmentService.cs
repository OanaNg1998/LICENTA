using JUSTMOVE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.EquipmentService
{
    public interface IEquipmentService
    {
        public ICollection<Equipment> GetEquipmentProducts();
        public void UpdateProductInfo(Equipment updatedProduct);
        public ICollection<Equipment> GetEquipmentOrderedDescbyPrice();
        public ICollection<Equipment> GetEquipmentOrderedCrescbyPrice();
    }
}
