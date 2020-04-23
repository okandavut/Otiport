using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Otiport.API.Contract.Request.ProfileItems;
using Otiport.API.Contract.Response.ProfileItems;
using Otiport.API.Helpers;
using Otiport.API.Services;

namespace Otiport.API.Controllers
{
    [Route("profile-items")]
    [ApiController]
    public class ProfileItemsController : ApiControllerBase
    {
        private readonly IProfileItemService _profileItemService;

        public ProfileItemsController(IProfileItemService profileItemService)
        {
            _profileItemService = profileItemService;
        }
        [HttpPost]
        public async Task<IActionResult> AddProfileItem([FromBody] AddProfileItemRequest request)
        {
            var response = await _profileItemService.AddProfileItemAsync(request);
            return GenerateResponse(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetProfileItems()
        {
            GetProfileItemsRequest request = new GetProfileItemsRequest();
            var response = await _profileItemService.GetProfileItemsAsync(request);
            return GenerateResponse(response);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProfileItem([FromBody] DeleteProfileItemRequest request)
        {
            var response = await _profileItemService.DeleteProfileItemAsync(request);
            return GenerateResponse(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProfileItem([FromRoute] int id, [FromBody] UpdateProfileItemRequest request)
        {
            request = request ?? new UpdateProfileItemRequest();
            request.Id = id;
            var response = await _profileItemService.UpdateProfileItemAsync(request);
            return GenerateResponse(response);

        }
    }
}
