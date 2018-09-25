using Otiport.API.Contract.Models;
using Otiport.API.Data.Entities.Users;

namespace Otiport.API.Mappers.Implementations
{
    public class UserMapper : IUserMapper
    {
        public UserModel ToModel(UserEntity entity)
        {
            return new UserModel()
            {
                City = entity.City,
                Country = entity.Country,
                District = entity.District,
                Name = entity.Name,
                Password = entity.Password,
                Surname = entity.Surname,
                Username = entity.Username,
                BirthDate = entity.BirthDate,
                EmailAddress = entity.EmailAddress,
                ProfilePictureUrl = entity.ProfilePictureUrl
            };
        }

        public UserEntity ToEntity(UserModel model)
        {
            return new UserEntity()
            {
                City = model.City,
                Country = model.Country,
                District = model.District,
                Name = model.Name,
                Password = model.Password,
                Surname = model.Surname,
                Username = model.Username,
                BirthDate = model.BirthDate,
                EmailAddress = model.EmailAddress,
                ProfilePictureUrl = model.ProfilePictureUrl
            };
        }
    }
}