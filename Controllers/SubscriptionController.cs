using JUSTMOVE.Models;
using JUSTMOVE.Services.SubscriptionService;
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
    public class SubscriptionController : ControllerBase
    {
        private readonly ISubscriptionService _subscriptionService;
        public SubscriptionController(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        [HttpPost]
        public ActionResult<Subscription> CreateAdoption(Subscription subscription)
        {
            Subscription result = _subscriptionService.CreateSubscription(subscription);
            if (result == null)
            {
                return Conflict(subscription.Id);
            }
            return Ok(subscription);
        }

    }
}
