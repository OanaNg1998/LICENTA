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
        [HttpGet("OrderNPDescByPrice")]
        public ICollection<NutritionProduct> GetProductsOrderedDesc()
        {
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // id of the logged in user
            //  var userId = "d79952bf-757b-42ec-9b0f-b11b136f5606";
            return _nutritionProductService.GetNProductsOrderedDescbyPrice();
        }
        [HttpGet("OrderNPCrescByPrice")]
        public ICollection<NutritionProduct> GetProductsOrderedCresc()
        {
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // id of the logged in user
            //  var userId = "d79952bf-757b-42ec-9b0f-b11b136f5606";
            return _nutritionProductService.GetNProductsOrderedCrescbyPrice();
        }
    }
}
