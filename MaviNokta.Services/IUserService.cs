using MaviNokta.DTOs.Users;
using MaviNokta.Models.Users;
using System.Threading.Tasks;

namespace MaviNokta.Services
{
    public interface IUserService
    {
        Task<UserDTO> CreateUser(CreateUserModel model);
    }
}