using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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

        public List<CountryEntity> GetCountries()
        {
            return _dbContext.Countries.ToList();
        }
    }
}
