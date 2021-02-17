using JUSTMOVE.Models;
using JUSTMOVE.Repositories.GenericRepository.AddressRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.AddressService
{
    public class AddressService:IAddressService
    {
        private readonly IAddressRepository _addressRepository;


        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;

        }
        public ICollection<string> GetAddresIdFromGivenCity(string city)
        {
            ICollection<string> cityAddressIds = new List<string>();
            var cityAddress = _addressRepository.FindByCity(city);
            foreach (Address cityaddress in cityAddress)
            {
                cityAddressIds.Add(cityaddress.Id);
            }
            return cityAddressIds;


        }

        
    }
}
