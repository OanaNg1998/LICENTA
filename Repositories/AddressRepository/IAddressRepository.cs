using JUSTMOVE.Models;
using System;
using System.Collections.Generic;
using JUSTMOVE.Repositories.GenericRepository;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Repositories.GenericRepository.AddressRepository
{
    public interface IAddressRepository:IGenericRepository<Address>
    {
        public IEnumerable<Address> FindByCity(string city);
    }
}
