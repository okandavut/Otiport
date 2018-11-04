using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Otiport.API.Contract.Request.Common;
using Otiport.API.Contract.Request.Users;
using Otiport.API.Contract.Response.Common;
using Otiport.API.Helpers;
using Otiport.API.Services;

namespace Otiport.API.Controllers
{
    [Route("address")]
    public class AddressInformationsController : ApiControllerBase
    {
        private readonly IAddressInformationService _addressInformationService;

        public AddressInformationsController(IAddressInformationService addressInformationService)
        {
            _addressInformationService = addressInformationService;
        }
        [HttpPost, Route("getcountries")]
        public async Task<GetCountriesResponse> GetCountries([FromBody] GetCountriesRequest request)
        {
            var response = await _addressInformationService.GetCountriesAsync(request);
            if (response == null)
            {
                return null;
            }
            return response;
        }
    }
}
