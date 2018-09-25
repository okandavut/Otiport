using Otiport.API.Contract.Models;
using Otiport.API.Data.Entities.Users;

namespace Otiport.API.Mappers
{
    public interface IUserMapper
    {
        UserModel ToModel(UserEntity entity);
        UserEntity ToEntity(UserModel model);
    }
}