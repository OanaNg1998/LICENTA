using JUSTMOVE.Models;
using JUSTMOVE.Repositories.SubscriptionRepository;
using JUSTMOVE.Repositories.UserRepository;
using JUSTMOVE.Services.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Just_Move.Services.UserSubscriptionService
{
    public class UserSubscriptionService: IUserSubscriptionService
    {
        private readonly IUserSubscriptionRepository _userSubscriptionRepository;
        private readonly IUserRepository _userRepository;
        private readonly IUserService _userService;
        

        public UserSubscriptionService(IUserSubscriptionRepository userSubscriptionRepository, IUserRepository userRepository, IUserService userService)
        {
            _userSubscriptionRepository = userSubscriptionRepository;
            _userRepository = userRepository;
            _userService = userService;
           
        }

       

        public bool CreateUserSubscription(string userId, string subscriptionCode,string gymId)
        {
            bool isCreated = true;
            ApplicationUser user = _userRepository.FindById(userId);
            var allUserSubscriptionCodes = _userSubscriptionRepository.GetAll().Select(x => x.Code);
            if (allUserSubscriptionCodes.Contains(subscriptionCode))
            {
                isCreated = false;
                return isCreated;
            }
            
            UserSubscription userSubscription = new UserSubscription
            {
                Id = Guid.NewGuid().ToString(),
           
                UserId = userId,
               
                Code = subscriptionCode,
                GymId=gymId
               
            };
            _userSubscriptionRepository.Create(userSubscription);
           
          

            return isCreated;
        }
    }
}
