using JUSTMOVE.Models;
using JUSTMOVE.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Repositories.SubscriptionRepository
{
   public interface IUserSubscriptionRepository:IGenericRepository<UserSubscription>
    {
        public IEnumerable<UserSubscription> FindByUserId(string id);
    }
}
