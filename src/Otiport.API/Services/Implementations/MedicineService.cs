using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Otiport.API.Contract.Request.Medicines;
using Otiport.API.Contract.Response.Medicines;
using Otiport.API.Mappers;
using Otiport.API.Providers;
using Otiport.API.Repositories;

namespace Otiport.API.Services.Implementations
{
    public class MedicineService : IMedicineService
    {
        private readonly ILogger<UserService> _logger;
        private readonly IMedicineRepository _medicineRepository;
        private readonly IConfiguration _configuration;

        public MedicineService(ILogger<UserService> logger, IUserMapper userMapper,
            IMedicineRepository medicineRepository,
            ITokenProvider tokenProvider, IConfiguration configuration)
        {
            _logger = logger;
            _medicineRepository = medicineRepository;
            _configuration = configuration;
        }
        public async Task<AddMedicineResponse> AddMedicineAsync(AddMedicineRequest request)
        {
            var response = new AddMedicineResponse();
            bool status = await _medicineRepository.AddMedicineAsync(request.Title, request.Description);
            if(status) response.StatusCode = (int)HttpStatusCode.OK;
            else
                _logger.LogWarning(""); //TODO - LOGGING
            return response;
        }

        public async Task<DeleteMedicineResponse> DeleteMedicineAsync(DeleteMedicineRequest request)
        {
            var response = new DeleteMedicineResponse();
            bool status = await _medicineRepository.DeleteMedicineAsync(request.MedicineId);
            if (status) response.StatusCode = (int)HttpStatusCode.OK;
            else
                _logger.LogWarning(""); //TODO - LOGGING
            return response;
        }

        public async Task<GetMedicinesResponse> GetMedicinesAsync()
        {
            var response = new GetMedicinesResponse();
            response.ListOfMedicines = await _medicineRepository.GetMedicinesAsync();
            return response;
        }
    }
}
