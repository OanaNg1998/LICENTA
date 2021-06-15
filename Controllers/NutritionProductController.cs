using JUSTMOVE.Models;
using JUSTMOVE.Services.NutritionProfuctService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class NutritionProductController : ControllerBase
    {
        private readonly INutritionProductService _nutritionProductService;
        public NutritionProductController(INutritionProductService  nutritionProductService)
        {
            _nutritionProductService = nutritionProductService;

        }
        [HttpGet]
        public ICollection<NutritionProduct> GetNutritionProductsFromEquipment()
        {

            return _nutritionProductService.GetNutritionProducts();

        }
    }
}
