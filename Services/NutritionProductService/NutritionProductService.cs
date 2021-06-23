using JUSTMOVE.Models;
using JUSTMOVE.Repositories.NutritionProductRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.NutritionProfuctService
{
    public class NutritionProductService:INutritionProductService
    {
        private readonly INutritionProductRepository _nutritionProductRepository;
       
        public NutritionProductService(INutritionProductRepository nutritionProductRepository)
        {
            _nutritionProductRepository = nutritionProductRepository;
           

        }
        public ICollection<NutritionProduct> GetNutritionProducts()
        {
            return _nutritionProductRepository.GetAll();
        }
        public ICollection<NutritionProduct> GetNProductsOrderedDescbyPrice()
        {

            ICollection<NutritionProduct> orderedNProducts = new List<NutritionProduct>();
            var equipment = _nutritionProductRepository.GetAll().OrderByDescending(x => x.Price);
            foreach (NutritionProduct eqpm in equipment)
            {
                orderedNProducts.Add(eqpm);
            }


            return orderedNProducts;

        }
        public ICollection<NutritionProduct> GetNProductsOrderedCrescbyPrice()
        {

            ICollection<NutritionProduct> orderedNProducts = new List<NutritionProduct>();
            var equipment = _nutritionProductRepository.GetAll().OrderBy(x => x.Price);
            foreach (NutritionProduct eqpm in equipment)
            {
                orderedNProducts.Add(eqpm);
            }


            return orderedNProducts;

        }
    }
}
