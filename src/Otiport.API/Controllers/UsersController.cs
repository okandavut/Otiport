using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Otiport.API.Helpers;
using Microsoft.AspNetCore.Mvc;
using Otiport.API.Data.DTOs.Users;
using Otiport.API.Models;
using Otiport.API.Models.Users;
using Otiport.API.Services;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Otiport.API.Controllers
{
    [Route("users")]
    public class UsersController : BaseController
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [ProducesResponseType(typeof(UserDTO), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserModel model)
        {
            var user = await _userService.CreateUser(model);
            if (user == null)
            {
                return BadRequest();
            }

            return StatusCode((int)HttpStatusCode.Created, user);
        }
    }
}
