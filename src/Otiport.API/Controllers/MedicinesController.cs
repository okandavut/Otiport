﻿using System;
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
    [ApiController]
    public class MedicinesController : ApiControllerBase
    {
        private readonly IMedicineService _medicineService;

        public MedicinesController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }
        [HttpPost]
        public async Task<IActionResult> AddMedicine([FromBody] AddMedicineRequest request)
        {
            var response = await _medicineService.AddMedicineAsync(request);
            return GenerateResponse(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetMedicines()
        {
            GetMedicinesRequest request = new GetMedicinesRequest();
            var response = await _medicineService.GetMedicinesAsync(request);
            return GenerateResponse(response);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteMedicine([FromBody] DeleteMedicineRequest request)
        {
            var response = await _medicineService.DeleteMedicineAsync(request);
            return GenerateResponse(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMedicine([FromRoute] int id, [FromBody] UpdateMedicineRequest request)
        {
            request = request ?? new UpdateMedicineRequest();
            request.Id = id;
            var response = await _medicineService.UpdateMedicinesAsync(request);
            return GenerateResponse(response);

        }
    }
}
