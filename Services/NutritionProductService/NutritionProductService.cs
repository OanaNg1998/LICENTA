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
    }
}
