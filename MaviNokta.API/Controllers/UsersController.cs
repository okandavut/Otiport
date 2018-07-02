using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaviNokta.Models.Users;
using MaviNokta.Services;
using Microsoft.AspNetCore.Mvc;

namespace MaviNokta.API.Controllers
{
    [Route("users")]
    public class UsersController : BaseController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserModel model)
        {
            var user = await _userService.CreateUser(model);
            if (user == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(user);
            }
        }
    }
}
