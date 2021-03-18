using JUSTMOVE.Models;
using JUSTMOVE.Services.GymTrainingService;
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
    public class GymTrainingController : ControllerBase
    { 


        private readonly IGymTrainingService _gymTrainingService;

        public GymTrainingController(IGymTrainingService gymTrainingService)
        {
            _gymTrainingService = gymTrainingService;
            
        }
        [HttpGet("{id}")]
        public ICollection<Training> GetClassesByGym(string id)
        {
            
            //city = _userService.GetCityByAddressId("7");//7-AddressId-ul userului logat
            return _gymTrainingService.GetGymTrainingsByGymId(id);

        }

    }
}
