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
        Task<IEnumerable<CountryEntity>> GetCountries();
        Task<IEnumerable<CityEntity>> GetCities(GetCitiesRequest request);
        Task<IEnumerable<DistrictEntity>> GetDistricts(GetDistrictsRequest request);
    }
}
