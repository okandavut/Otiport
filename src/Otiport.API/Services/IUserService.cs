using System.Threading.Tasks;
using Otiport.API.Contract.Request.Users;
using Otiport.API.Contract.Response.Users;
using Otiport.API.Controllers;

namespace Otiport.API.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request);
        Task<LoginResponse> LoginAsync(LoginRequest request);
    }
}