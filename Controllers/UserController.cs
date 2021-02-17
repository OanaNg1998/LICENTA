

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using JUSTMOVE.Services.UserService;
using JUSTMOVE.Models;

namespace Just_Move.Controllers
{
  //  [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ApplicationUser GetUserInfo()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // id of the logged in user
          //  var userId = "d79952bf-757b-42ec-9b0f-b11b136f5606";
            return _userService.GetUserInfo(userId);
        }

        [HttpPut]
        public void UpdateInfo(ApplicationUser userDTO)
        {
            _userService.UpdateUserInfo(userDTO);
        }



    }
}
