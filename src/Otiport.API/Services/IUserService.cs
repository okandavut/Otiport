using System.Threading.Tasks;
using Otiport.API.Contract.Request.Users;
using Otiport.API.Contract.Response.Users;

namespace Otiport.API.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request);
    }
}