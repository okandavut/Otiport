using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Otiport.API.Contract.Request.Treatments;
using Otiport.API.Helpers;
using Otiport.API.Services;

namespace Otiport.API.Controllers
{
    [Route("Treatments")]
    public class TreatmentsController : ApiControllerBase
    {
        private readonly ITreatmentService _treatmentService;

        public TreatmentsController(ITreatmentService treatmentService)
        {
            _treatmentService = treatmentService;
        }

        [HttpPost]
        public async Task<IActionResult> AddTreatment([FromBody] AddTreatmentRequest request)
        {
            var response = await _treatmentService.AddTreatmentAsync(request);
            return GenerateResponse(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetTreatments(GetTreatmentsRequest request)
        {
            var response = await _treatmentService.GetTreatmentsAsync(request);
            return GenerateResponse(response);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTreatment([FromBody] DeleteTreatmentRequest request)
        {
            var response = await _treatmentService.DeleteTreatmentAsync(request);
            return GenerateResponse(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTreatment([FromRoute] int id, [FromBody] UpdateTreatmentRequest request)
        {
            request = request ?? new UpdateTreatmentRequest();
            request.Id = id;
            var response = await _treatmentService.UpdateTreatmentsAsync(request);
            return GenerateResponse(response);

        }
    }
}
