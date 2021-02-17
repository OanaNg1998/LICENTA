using JUSTMOVE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.SubscriptionService
{
   public interface ISubscriptionService
    {
        public Subscription CreateSubscription(Subscription subscription);
    }
}
