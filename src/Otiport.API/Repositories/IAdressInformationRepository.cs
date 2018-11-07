using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Contract.Request.Common;
using Otiport.API.Data.Entities.AddressInformations;

namespace Otiport.API.Repositories
{
    public interface IAdressInformationRepository : IRepository
    {
        Task<IEnumerable<CountryEntity>> GetCountriesAsync();
        Task<IEnumerable<CityEntity>> GetCitiesAsync(string CountryId);
        Task<IEnumerable<DistrictEntity>> GetDistrictsAsync(string CityId);
    }
}
