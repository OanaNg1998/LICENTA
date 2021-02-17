

using JUSTMOVE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.UserService
{
    public interface IUserService
    {
        public ApplicationUser GetUserInfo(string userId);
        public void UpdateUserInfo(ApplicationUser userDTO);
        public string GetCityByAddressId(string addressId);



    }
}
