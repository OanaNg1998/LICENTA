using JUSTMOVE.Models;
using JUSTMOVE.Repositories.EquipmentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.EquipmentService
{
    public class EquipmentService:IEquipmentService
    {
        private readonly IEquipmentRepository _equipmentRepository;


        public EquipmentService(IEquipmentRepository equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;

        }
        public ICollection<Equipment> GetEquipmentProducts()
        {
            return _equipmentRepository.GetAll();
        }
        public void UpdateProductInfo(Equipment updatedProduct)
        {
            string id = updatedProduct.Id;

            Equipment product = _equipmentRepository.FindById(id);
           // product.ProductName = updatedProduct.ProductName;
            product.Category = updatedProduct.Category;
            product.Price = updatedProduct.Price;
            product.Description = updatedProduct.Description;
            product.Image = updatedProduct.Image;
            product.Gender = updatedProduct.Gender;
            product.Quantity = updatedProduct.Quantity;

            _equipmentRepository.Update(product);
        }
        public ICollection<Equipment> GetEquipmentOrderedDescbyPrice()
        {

            ICollection<Equipment> orderedProducts = new List<Equipment>();
            var equipment = _equipmentRepository.GetAll().OrderByDescending(x => x.Price);
            foreach (Equipment eqpm in equipment)
            {
                orderedProducts.Add(eqpm);
            }


                return orderedProducts;

        }
        public ICollection<Equipment> GetEquipmentOrderedCrescbyPrice()
        {

            ICollection<Equipment> orderedProducts = new List<Equipment>();
            var equipment = _equipmentRepository.GetAll().OrderBy(x => x.Price);
            foreach (Equipment eqpm in equipment)
            {
                orderedProducts.Add(eqpm);
            }


            return orderedProducts;

        }
        public ICollection<Equipment> GetBrandsSearchBar()
        {
            ICollection<Equipment> equipments = new List<Equipment>();
            var eqp = _equipmentRepository.GetAll();
            ICollection<String> Brands = new List<String>();
            int ok = 0;

            foreach (Equipment eq in eqp)
            {

                foreach (String brand in Brands)
                {
                    if (eq.Brand == brand) ok = 1;
                }
                if (ok == 0)
                {
                    equipments.Add(eq);
                    Brands.Add(eq.Brand);
                }
                ok = 0;



            }
            return equipments;


        }
    }
}
