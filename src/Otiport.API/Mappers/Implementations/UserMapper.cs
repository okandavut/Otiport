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
                FirstName = entity.FirstName,
                MiddleName = entity.MiddleName,
                LastName = entity.LastName,
                Password = entity.Password,
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
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                Password = model.Password,
                Username = model.Username,
                BirthDate = model.BirthDate,
                EmailAddress = model.EmailAddress,
                ProfilePictureUrl = model.ProfilePictureUrl
            };
        }
    }
}