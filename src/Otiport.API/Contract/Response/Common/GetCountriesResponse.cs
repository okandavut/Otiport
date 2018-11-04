using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Data.Entities.AddressInformations;

namespace Otiport.API.Contract.Response.Common
{
    public class GetCountriesResponse
    {
        public List<CountryEntity> ListOfCountries = new List<CountryEntity>();
    }
}
