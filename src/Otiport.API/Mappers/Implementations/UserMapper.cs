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
                CityId = entity.CityId,
                CountryId = entity.CountryId,
                DistrictId = entity.DistrictId,
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
                CityId = model.CityId,
                CountryId = model.CountryId,
                DistrictId = model.DistrictId,
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