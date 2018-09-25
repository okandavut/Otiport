using Otiport.API.Data.DTOs.Users;
using Otiport.API.Models.Users;
using System.Threading.Tasks;

namespace Otiport.API.Services
{
    public interface IUserService
    {
        Task<UserDTO> CreateUser(CreateUserModel model);
    }
}