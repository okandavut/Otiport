using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Otiport.API.Contract.Request.Common;
using Otiport.API.Contract.Response.Common;
using Otiport.API.Data.Entities.AddressInformations;
using Otiport.API.Mappers;
using Otiport.API.Providers;
using Otiport.API.Repositories;

namespace Otiport.API.Services.Implementations
{
    public class AddressInformationService : IAddressInformationService
    {
        private readonly ILogger<UserService> _logger;
        private readonly IUserMapper _userMapper;
        private readonly IAdressInformationRepository _adressInformationRepository;
        private readonly ITokenProvider _tokenProvider;
        private readonly IConfiguration _configuration;

        public AddressInformationService(ILogger<UserService> logger, IUserMapper userMapper,
            IAdressInformationRepository adressInformationRepository,
            ITokenProvider tokenProvider, IConfiguration configuration)
        {
            _logger = logger;
            _userMapper = userMapper;
            _adressInformationRepository = adressInformationRepository;
            _tokenProvider = tokenProvider;
            _configuration = configuration;
        }
        public async Task<GetCountriesResponse> GetCountriesAsync()
        {
            var response = new GetCountriesResponse();
            response.ListOfCountries = await _adressInformationRepository.GetCountriesAsync();
            return response;
        }

        public async Task<GetCitiesResponse> GetCitiesAsync(GetCitiesRequest request)
        {
            var response = new GetCitiesResponse();
            response.ListOfCities = await _adressInformationRepository.GetCitiesAsync(request.CountryId);
            return response;
        }
        public async Task<GetDistrictsResponse> GetDistrictsAsync(GetDistrictsRequest request)
        {
            var response = new GetDistrictsResponse();
            response.Districts = await _adressInformationRepository.GetDistrictsAsync(request.CityId);
            return response;
        }
    }
}
