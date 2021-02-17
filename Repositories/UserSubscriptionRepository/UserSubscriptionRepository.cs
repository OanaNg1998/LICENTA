
using JUSTMOVE.Models;
using JUSTMOVE.Repositories.GenericRepository;
using JUSTMOVE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace JUSTMOVE.Repositories.SubscriptionRepository
{
    public class UserSubscriptionRepository: GenericRepository<UserSubscription>, IUserSubscriptionRepository
    {
        public UserSubscriptionRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<UserSubscription> FindByUserId(string id)
        {
            return GetAll().Where(x => x.UserId == id);
        }
    }
}