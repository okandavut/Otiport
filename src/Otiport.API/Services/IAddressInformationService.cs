using System.Threading.Tasks;
using Otiport.API.Contract.Request.Common;
using Otiport.API.Contract.Response.Common;

namespace Otiport.API.Services
{
    public interface IAddressInformationService
    {
        Task<GetCountriesResponse> GetCountriesAsync();
    }
}
