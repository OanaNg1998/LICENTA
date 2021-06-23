using JUSTMOVE.Models;
using JUSTMOVE.Services.EquipmentService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;
        public EquipmentController(IEquipmentService equipmentService)
        {
            _equipmentService = equipmentService;

        }
        [HttpGet]
        public ICollection<Equipment> GetProductsFromEquipment()
        {

            return _equipmentService.GetEquipmentProducts();

        }
        [HttpPut]
        public void UpdateInfo(Equipment product)
        {
            _equipmentService.UpdateProductInfo(product);
        }
        [HttpGet("OrderDescByPrice")]
        public ICollection<Equipment> GetProductsOrderedDesc()
        {
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // id of the logged in user
            //  var userId = "d79952bf-757b-42ec-9b0f-b11b136f5606";
            return _equipmentService.GetEquipmentOrderedDescbyPrice();
        }
        [HttpGet("OrderCrescByPrice")]
        public ICollection<Equipment> GetProductsOrderedCresc()
        {
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // id of the logged in user
            //  var userId = "d79952bf-757b-42ec-9b0f-b11b136f5606";
            return _equipmentService.GetEquipmentOrderedCrescbyPrice();
        }
        [HttpGet("GetBrands")]
        public ICollection<Equipment> GetBrandsSearchbarFilter()
        {
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // id of the logged in user
            //  var userId = "d79952bf-757b-42ec-9b0f-b11b136f5606";
            return _equipmentService.GetBrandsSearchBar();
        }


    }
}
