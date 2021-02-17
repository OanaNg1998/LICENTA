using JUSTMOVE.Data;
using JUSTMOVE.Models;
using JUSTMOVE.Repositories.GenericRepository;
using JUSTMOVE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace JUSTMOVE.Repositories.GenericRepository.AddressRepository
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(ApplicationDbContext context) : base(context)
        {

        }
        public IEnumerable<Address> FindByCity(string city)
        {
            return GetAll().Where(x => x.City== city);
        }
    }
}
