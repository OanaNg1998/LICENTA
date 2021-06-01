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

        public ICollection<Address> GetAddresses()
        {
            ICollection<Address> cityAddressIds = new List<Address>();
            var cityAddress = _addressRepository.GetAll();
            ICollection<String> Cities = new List<String>();
            int ok = 0;
            
            foreach (Address cityaddress in cityAddress)
            {

                foreach (String city in Cities)
                {
                    if (cityaddress.City == city) ok = 1;
                }
                if (ok == 0)
                {
                    cityAddressIds.Add(cityaddress);
                    Cities.Add(cityaddress.City);
                }
                ok = 0;
               
               
             
            }
            return cityAddressIds;


        }


    }
}
