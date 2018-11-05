using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Data.Entities.AddressInformations;

namespace Otiport.API.Repositories
{
    public interface IAdressInformationRepository : IRepository
    {
        Task<IEnumerable<CountryEntity>> GetCountries();
    }
}
    