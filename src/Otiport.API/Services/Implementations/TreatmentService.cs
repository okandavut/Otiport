using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Otiport.API.Contract.Request.Treatments;
using Otiport.API.Contract.Response.Treatments;
using Otiport.API.Data;
using Otiport.API.Data.Entities.Treatment;
using Otiport.API.Mappers;
using Otiport.API.Repositories;

namespace Otiport.API.Services.Implementations
{
    public class TreatmentService : ITreatmentService
    {
        private readonly ILogger<MedicineService> _logger;
        private readonly ITreatmentRepository _treatmentRepository;
        private readonly ITreatmentMapper _treatmentMapper;

        public TreatmentService(ILogger<MedicineService> logger,
            ITreatmentRepository treatmentRepository,
            ITreatmentMapper treatmentMapper)
        {
            _logger = logger;
            _treatmentRepository = treatmentRepository;
            _treatmentMapper = treatmentMapper;
        }
        public async Task<AddTreatmentResponse> AddTreatmentAsync(AddTreatmentRequest request)
        {
            var response = new AddTreatmentResponse();
            TreatmentEntity entity = _treatmentMapper.ToEntity(request); 
            bool status = await _treatmentRepository.AddTreatmentAsync(entity);
            if (status)
            {
                response.StatusCode = (int)HttpStatusCode.Created;
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                //TODO (okandavut) : LOGGING
                _logger.LogWarning("");
            }
            
            return response;
        }

        public async Task<DeleteTreatmentResponse> DeleteTreatmentAsync(DeleteTreatmentRequest request)
        {
            var response = new DeleteTreatmentResponse();
            TreatmentEntity entity = await _treatmentRepository.GetTreatmentById(request.Id);
           
            if (entity == null)
            {
                response.StatusCode = (int)HttpStatusCode.NotFound;
                return response;
            }
            
            bool status = await _treatmentRepository.DeleteTreatmentAsync(entity);
            if (status)
            {
                response.StatusCode = (int)HttpStatusCode.OK;
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                //TODO (okandavut) : LOGGING
                _logger.LogWarning("");
            }
            
            return response;
        }

        public async Task<GetTreatmentsResponse> GetTreatmentsAsync(GetTreatmentsRequest request)
        {
            var response = new GetTreatmentsResponse();
            var list = await _treatmentRepository.GetTreatmentsAsync();
            response.Treatments = list.Select(x => _treatmentMapper.ToModel(x)).ToList();
            return response;
        }

        public async Task<UpdateTreatmentResponse> UpdateTreatmentsAsync(UpdateTreatmentRequest request)
        {
            var response = new UpdateTreatmentResponse();
            TreatmentEntity entity = await _treatmentRepository.GetTreatmentById(request.Id);
            
            if (entity == null)
            {
                response.StatusCode = (int)HttpStatusCode.NotFound;
                return response;
            }
            
            entity.Description = request.Description;
            entity.Title = request.Title;
            var result = await _treatmentRepository.UpdateTreatmentsAsync(entity);

            if (result)
            {
                response.StatusCode = (int) HttpStatusCode.OK;
            }
            else
            {
                response.StatusCode = (int) HttpStatusCode.InternalServerError;
                _logger.LogError("An Error occurred");
            }
            
            return response;
        }
    }
}
