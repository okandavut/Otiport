using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Contract.Request.Treatments;
using Otiport.API.Contract.Response.Treatments;

namespace Otiport.API.Services
{
    public interface ITreatmentService
    {
        Task<AddTreatmentResponse> AddTreatmentAsync(AddTreatmentRequest request);
        Task<DeleteTreatmentResponse> DeleteTreatmentAsync(DeleteTreatmentRequest request);
        Task<GetTreatmentsResponse> GetTreatmentsAsync(GetTreatmentsRequest request);
        Task<UpdateTreatmentResponse> UpdateTreatmentsAsync(UpdateTreatmentRequest request);
    }
}