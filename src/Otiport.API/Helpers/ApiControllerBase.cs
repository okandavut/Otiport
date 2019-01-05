using Microsoft.AspNetCore.Mvc;
using Otiport.API.Contract;

namespace Otiport.API.Helpers
{
    public class ApiControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        [NonAction]
        public IActionResult GenerateResponse(ResponseBase response)
        {
            return StatusCode(response.StatusCode, response);
        }

    }
}