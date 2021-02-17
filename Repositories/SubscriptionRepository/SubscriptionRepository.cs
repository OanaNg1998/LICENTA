using JUSTMOVE.Data;
using JUSTMOVE.Models;
using JUSTMOVE.Repositories.GenericRepository;
using JUSTMOVE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace JUSTMOVE.Repositories.SubscriptionRepository
{
    public class SubscriptionRepository : GenericRepository<Subscription>, ISubscriptionRepository
    {
        public SubscriptionRepository(ApplicationDbContext context) : base(context)
        {

        }


    }
}
