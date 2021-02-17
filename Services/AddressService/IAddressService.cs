using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.AddressService
{
    public interface IAddressService
    {
        public ICollection<string> GetAddresIdFromGivenCity(string city);
    }
}
