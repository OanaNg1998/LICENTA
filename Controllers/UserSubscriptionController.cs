using Just_Move.Services.UserSubscriptionService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Just_Move.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSubscriptionController : ControllerBase
    {
        private readonly IUserSubscriptionService _userSubscriptionService;
        public UserSubscriptionController(IUserSubscriptionService donationService)
        {
            _userSubscriptionService = donationService;
        }

      /*  [HttpPost]
        public IActionResult CreateUserSubscription([FromBody] string gymId)
        {
             var userId = "df4a5c5a-d5df-4717-9d66-8c74acc447a1";
             var subscriptionCode = "1111";
            var isUserSubscriptionCreated = _userSubscriptionService.CreateUserSubscription(userId, subscriptionCode,gymId);
            if (isUserSubscriptionCreated)
                return Ok();
            else
                return BadRequest("Code already exists");
        }
      */

    }
}
