using JUSTMOVE.Models;
using JUSTMOVE.Services.AddressService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Controllers
{ 

    [Route("api/[controller]")]
    [ApiController]
public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
           
        }
        [HttpGet]
        public ICollection<Address> GetAddresses()
        {

            return _addressService.GetAddresses();

        }

    }
}
