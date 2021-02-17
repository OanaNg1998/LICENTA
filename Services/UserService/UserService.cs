
using JUSTMOVE.Services.UserService;
using JUSTMOVE.Services.AddressService;
using JUSTMOVE.Models;
using JUSTMOVE.Repositories.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using JUSTMOVE.Repositories.GenericRepository.AddressRepository;
using JUSTMOVE.Models;

namespace Just_Move.Services.UserService
{
    public class UserService :IUserService 
    {
        private readonly IUserRepository _userRepository;
        private readonly IAddressRepository _addressRepository;
       

        public UserService(IUserRepository userRepository, IAddressRepository addressRepository)
        {
            _userRepository = userRepository;
            _addressRepository = addressRepository;
            
        }

        public ApplicationUser GetUserInfo(string userId)
        {
            ApplicationUser user = _userRepository.FindById(userId);
           
            
            return user;
        }
        public void UpdateUserInfo(ApplicationUser updateUser)
        {
            string id = "d79952bf-757b-42ec-9b0f-b11b136f5606";
           
            ApplicationUser user = _userRepository.FindById(id);
            user.LastName = updateUser.LastName;
            user.FirstName = updateUser.FirstName;
            user.AddressId = updateUser.AddressId;
            user.Gender = updateUser.Gender;
            user.IntrestDomain = updateUser.IntrestDomain;
            
            _userRepository.Update(user);
        }

        public string GetCityByAddressId(string addressId)
        {
            //addressId va fi addressid-uluserului logat
            var userAddress = _addressRepository.FindById(addressId);
            return userAddress.City;
        }





    }
}
