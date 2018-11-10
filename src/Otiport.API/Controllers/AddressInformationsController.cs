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
    [Route("address-informations")]
    public class AddressInformationsController : ApiControllerBase
    {
        private readonly IAddressInformationService _addressInformationService;

        public AddressInformationsController(IAddressInformationService addressInformationService)
        {
            _addressInformationService = addressInformationService;
        }
        
        [HttpGet, Route("countries")]
        public async Task<IActionResult> GetCountries()
        {
            var response = await _addressInformationService.GetCountriesAsync();
            if (response == null)
            {
                return BadRequest();
            }
            return StatusCode((int)HttpStatusCode.OK, response);
        }

        [HttpGet, Route("cities")]
        public async Task<IActionResult> GetCities(GetCitiesRequest request)
        {
            var response = await _addressInformationService.GetCitiesAsync(request);
            if (response == null)
            {
                return BadRequest();
            }
            return StatusCode((int)HttpStatusCode.OK, response);
        }
        
        [HttpGet, Route("districts")]
        public async Task<IActionResult> GetDistricts(GetDistrictsRequest request)
        {
            var response = await _addressInformationService.GetDistrictsAsync(request);
            
            if (response == null)
            {
                return BadRequest();
            }
            return StatusCode((int)HttpStatusCode.OK, response);
        }
    }
}
