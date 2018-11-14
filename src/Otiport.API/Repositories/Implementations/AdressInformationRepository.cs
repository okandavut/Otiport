using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Otiport.API.Contract.Request.Common;
using Otiport.API.Data;
using Otiport.API.Data.Entities.AddressInformations;

namespace Otiport.API.Repositories.Implementations
{
    public class AdressInformationRepository : IAdressInformationRepository
    {
        private readonly OtiportDbContext _dbContext;
        private readonly ILogger<IAdressInformationRepository> _logger;

        public AdressInformationRepository(OtiportDbContext dbContext, ILogger<IAdressInformationRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }

        public async Task<bool> SaveAsync()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Something went wrong");
                return false;
            }
        }

        public async Task<IEnumerable<CountryEntity>> GetCountriesAsync()
        {
            return await _dbContext.Countries.ToListAsync();
        }

        public async Task<IEnumerable<CityEntity>> GetCitiesAsync(string CountryId)
        {
            return await _dbContext.Cities.Where(x => x.Country.Id == int.Parse(CountryId)).ToListAsync();
        }
        public async Task<IEnumerable<DistrictEntity>> GetDistrictsAsync (string CityId)
        {
            return await _dbContext.Districts.Where(x => x.City.Id== int.Parse(CityId)).ToListAsync();
        }
    }
}
