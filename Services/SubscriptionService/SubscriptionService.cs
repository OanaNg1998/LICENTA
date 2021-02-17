using JUSTMOVE.Models;
using JUSTMOVE.Repositories.SubscriptionRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.SubscriptionService
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly ISubscriptionRepository _subscriptionRepository;


        public SubscriptionService(ISubscriptionRepository subscriptionRepository)
        {
            _subscriptionRepository = subscriptionRepository;

        }
        public Subscription CreateSubscription(Subscription subscription)
        {
            if (_subscriptionRepository.FindById(subscription.Id) != null)//nu exista alt abonament
            {
                return null;
            }
            _subscriptionRepository.Create(subscription);
          
           

            _subscriptionRepository.SaveChanges();
            return subscription;
        }
    }
}
