using JUSTMOVE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Models
{
    public class UserSubscription
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string SubscriptionId { get; set; }
        public string Code { get; set; }
        public string GymId { get; set; }
        public virtual Gym Gym { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Subscription Subscription { get; set; }
    }
}
