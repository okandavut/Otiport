using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.ExpressionVisitors;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Otiport.API.Contract.Request.Medicines;
using Otiport.API.Contract.Response.Medicines;
using Otiport.API.Data;
using Otiport.API.Data.Entities.Medicine;
using Otiport.API.Mappers;
using Otiport.API.Providers;
using Otiport.API.Repositories;

namespace Otiport.API.Services.Implementations
{
    public class MedicineService : IMedicineService
    {
        private readonly ILogger<UserService> _logger;
        private readonly OtiportDbContext _dbContext;

        private readonly IMedicineRepository _medicineRepository;
        private readonly IMedicineMapper _medicineMapper;

        public MedicineService(ILogger<UserService> logger, IUserMapper userMapper,
            IMedicineRepository medicineRepository,
            OtiportDbContext dbContext,
            IMedicineMapper medicineMapper)
        {
            _logger = logger;
            _medicineRepository = medicineRepository;
            _dbContext = dbContext;
            _medicineMapper = medicineMapper;
        }
        public async Task<AddMedicineResponse> AddMedicineAsync(AddMedicineRequest request)
        {
            var response = new AddMedicineResponse();
            MedicineEntity entity = new MedicineEntity()
            {
                Description = request.Description,
                Title = request.Title
            };
            bool status = await _medicineRepository.AddMedicineAsync(entity);
            if (status) response.StatusCode = (int)HttpStatusCode.OK;
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
            }
            bool status = await _medicineRepository.DeleteMedicineAsync(entity);
            if (status) response.StatusCode = (int)HttpStatusCode.OK;
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
    }
}
