using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Otiport.API.Contract.Request.Medicines;
using Otiport.API.Contract.Response.Medicines;
using Otiport.API.Data.Entities.Medicine;
using Otiport.API.Mappers;
using Otiport.API.Repositories;

namespace Otiport.API.Services.Implementations
{
    public class MedicineService : IMedicineService
    {
        private readonly ILogger<UserService> _logger;
        private readonly IMedicineRepository _medicineRepository;
        private readonly IMedicineMapper _medicineMapper;

        public MedicineService(ILogger<UserService> logger, IUserMapper userMapper,
            IMedicineRepository medicineRepository,
            IMedicineMapper medicineMapper)
        {
            _logger = logger;
            _medicineRepository = medicineRepository;
            _medicineMapper = medicineMapper;
        }
            
        public async Task<AddMedicineResponse> AddMedicineAsync(AddMedicineRequest request)
        {
            var response = new AddMedicineResponse();
            MedicineEntity entity = _medicineMapper.ToEntity(request);
            bool status = await _medicineRepository.AddMedicineAsync(entity);
            if (status)
            {
                response.StatusCode = (int)HttpStatusCode.Created;
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                _logger.LogWarning(""); //TODO - LOGGING
            }
            return response;
        }

        public async Task<DeleteMedicineResponse> DeleteMedicineAsync(DeleteMedicineRequest request)
        {
            var response = new DeleteMedicineResponse();
            MedicineEntity entity = await _medicineRepository.GetMedicineById(request.MedicineId);
           
            if (entity == null)
            {
                response.StatusCode = (int)HttpStatusCode.NotFound;
                return response;
            }
            
            bool status = await _medicineRepository.DeleteMedicineAsync(entity);
            if (status)
            {
                response.StatusCode = (int)HttpStatusCode.OK;
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                _logger.LogWarning(""); //TODO - LOGGING
            }
          
            return response;
        }

        public async Task<GetMedicinesResponse> GetMedicinesAsync(GetMedicinesRequest request)
        {
            var response = new GetMedicinesResponse();
            var list = await _medicineRepository.GetMedicinesAsync();
            response.Medicines = list.Select(x => _medicineMapper.ToModel(x)).ToList();
            return response;
        }

        public async Task<UpdateMedicineResponse> UpdateMedicinesAsync(UpdateMedicineRequest request)
        {
            var response = new UpdateMedicineResponse();
            MedicineEntity entity = await _medicineRepository.GetMedicineById(request.Id);
            if (entity == null)
            {
                response.StatusCode = (int)HttpStatusCode.NotFound;
                return response;
            }
            entity.Description = request.Description;
            entity.Title = request.Title;
            var result = await _medicineRepository.UpdateMedicinesAsync(entity);

            if (result)
            {
                response.StatusCode = (int) HttpStatusCode.OK;
            }
            else
            {
                response.StatusCode = (int) HttpStatusCode.InternalServerError;
                _logger.LogError("An error occurred");
            }
            
            return response;
        }
    }
}
