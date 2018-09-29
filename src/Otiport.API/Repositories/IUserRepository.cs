using System.Threading.Tasks;
using Otiport.API.Data.Entities.Users;

namespace Otiport.API.Repositories
{
    public interface IUserRepository : IRepository
    {
        Task<bool> IsExistsUserAsync(string username, string emailAddress);
        Task<UserEntity> AddAsync(UserEntity entity);
        Task<UserEntity> GetUserByCredentialsAsync(string emailAddress, string password);
    }
}