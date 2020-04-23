using Microsoft.AspNetCore.Mvc;
using Otiport.API.Contract;

namespace Otiport.API.Helpers
{
    public class ApiControllerBase : Controller
    {
        [NonAction]
        public IActionResult GenerateResponse(ResponseBase response)
        {
            return StatusCode(response.StatusCode, response);
        }

    }
}