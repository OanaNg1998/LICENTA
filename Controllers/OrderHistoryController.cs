using JUSTMOVE.Models;
using JUSTMOVE.Services.OrderHistoryService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderHistoryController : ControllerBase
    {

        private readonly IOrderHistoryService _orderHistoryService;
        public OrderHistoryController(IOrderHistoryService orederHistoryService)
        {
            _orderHistoryService = orederHistoryService;

        }

        [HttpPost]
        public async Task<IActionResult> MakeNewOrderAsync(OrderData data)
        {
            
            var isOrderCreated = await _orderHistoryService.MakeOrderAsync(data);
            if (isOrderCreated)
                return Ok();
            else
                return BadRequest("Code already exists");
        }

    }
}
