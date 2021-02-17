using JUSTMOVE.Models;
using JUSTMOVE.Repositories.GymRepository;
using JUSTMOVE.Services.AddressService;
using JUSTMOVE.Services.UserService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.GymService
{
    public class GymService:IGymService
    {
        private readonly IGymRepository _gymRepository;
        private readonly IAddressService _addressService;
        private readonly IGymService _gymService;
       


        public GymService(IGymRepository gymRepository, IAddressService addressService)
        {
            _gymRepository = gymRepository;
            _addressService = addressService;
           
          

        }

       
        public ICollection<Gym> GetGymsFromCity(string city)
        {
            
            ICollection<Gym> gymsFromCity = new List<Gym>();
            var gymsfromcity = _gymRepository.GetAll();
            foreach (String id in _addressService.GetAddresIdFromGivenCity(city))
            {
                foreach(Gym gym in gymsfromcity )
                {
                    if(id==gym.AddressId)
                    {
                        gymsFromCity.Add(gym);
                    }
                }
            }
            return gymsFromCity;

        }

        public void RemoveGymFromId( string id)
        {
            
            var gym = _gymRepository.FindById(id);
            _gymRepository.Delete(gym);
            
        }



    }
}
