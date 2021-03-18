using JUSTMOVE.Models;
using JUSTMOVE.Services.AddressService;
using JUSTMOVE.Services.GymService;
using JUSTMOVE.Services.UserService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GymController : ControllerBase
    {
        private readonly IGymService _gymService;
        private readonly IUserService _userService;
        public GymController(IGymService gymService, IUserService userService)
        {
            _gymService = gymService;
            _userService = userService;
        }
        [HttpGet]
        public ICollection<Gym> GetGymsFromCity(string city)
        {    
            //city = _userService.GetCityByAddressId("7");//7-AddressId-ul userului logat
            return _gymService.GetGymsFromCity(city);

        }
        [HttpDelete]
        public void RemoveGynById( string id)
        {
            id = "6";
            _gymService.RemoveGymFromId(id);
        }
    }
}
