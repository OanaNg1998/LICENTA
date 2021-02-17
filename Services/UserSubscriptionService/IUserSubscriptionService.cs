using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Just_Move.Services.UserSubscriptionService
{
   public interface IUserSubscriptionService
    {
        public Boolean CreateUserSubscription(string userId, string subscriptionCode,string gymId);
    }
}
