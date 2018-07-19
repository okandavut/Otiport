using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MaviNokta.API.Helpers;
using MaviNokta.DTOs.Users;
using MaviNokta.Models;
using MaviNokta.Models.Users;
using MaviNokta.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

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

        [SwaggerResponse((int)HttpStatusCode.Created, typeof(UserDTO))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, typeof(ErrorResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, typeof(ErrorResponse))]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserModel model)
        {
            var user = await _userService.CreateUser(model);
            if (user == null)
            {
                return BadRequest();
            }

            return StatusCode((int) HttpStatusCode.Created, user);
        }
    }
}
