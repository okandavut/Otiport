using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Otiport.API.Contract.Request.Medicines;
using Otiport.API.Helpers;
using Otiport.API.Services;

namespace Otiport.API.Controllers
{
    [Route("medicines")]
    public class MedicinesController : ApiControllerBase
    {
        private readonly IMedicineService _medicineService;

        public MedicinesController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }

        [HttpPost, Route("addMedicine")]
        public async Task<IActionResult> AddMedicine([FromBody] AddMedicineRequest request)
        {
            var response = await _medicineService.AddMedicineAsync(request);
            if (response == null)
            {
                return BadRequest();
            }

            return StatusCode((int)HttpStatusCode.OK, response);
        }
        [HttpGet, Route("medicines")]
        public async Task<IActionResult> GetMedicines()
        {
            var response = await _medicineService.GetMedicinesAsync();
            if (response == null)
            {
                return BadRequest();
            }
            return StatusCode((int)HttpStatusCode.OK, response);
        }

        [HttpPost, Route("deleteMedicine")]
        public async Task<IActionResult> DeleteMedicine([FromBody] DeleteMedicineRequest request)
        {
            var response = await _medicineService.DeleteMedicineAsync(request);
            if (response == null)
            {
                return BadRequest();
            }

            return StatusCode((int)HttpStatusCode.OK, response);
        }
    }
}
