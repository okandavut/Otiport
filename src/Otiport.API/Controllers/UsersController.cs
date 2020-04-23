using System.Net;
using System.Threading.Tasks;
using Otiport.API.Helpers;
using Microsoft.AspNetCore.Mvc;
using Otiport.API.Contract.Request.Users;
using Otiport.API.Contract.Response.Users;
using Otiport.API.Models;
using Otiport.API.Services;

namespace Otiport.API.Controllers
{
    [Route("users")]
    [ApiController]
    public class UsersController : ApiControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [ProducesResponseType(typeof(CreateUserResponse), (int) HttpStatusCode.Created)]
        [ProducesResponseType(typeof(ErrorResponse), (int) HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), (int) HttpStatusCode.BadRequest)]
        [HttpPost, Route("register")]
        public async Task<IActionResult> Create([FromBody] CreateUserRequest request)
        {
            var response = await _userService.CreateUserAsync(request);
            if (response == null)
            {
                return BadRequest();
            }

            return StatusCode((int) HttpStatusCode.Created, response);
        }

        [HttpPost, Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var response = await _userService.LoginAsync(request);
            if (response == null)
            {
                return BadRequest();
            }

            return StatusCode((int) HttpStatusCode.OK, response);
        }
    }
}