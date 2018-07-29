using Otiport.DTOs.Users;
using Otiport.Models.Users;
using System.Threading.Tasks;

namespace Otiport.Services
{
    public interface IUserService
    {
        Task<UserDTO> CreateUser(CreateUserModel model);
    }
}