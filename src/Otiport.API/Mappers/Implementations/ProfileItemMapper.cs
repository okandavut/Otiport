using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Contract.Models;
using Otiport.API.Contract.Request.ProfileItems;
using Otiport.API.Data.Entities.ProfileItem;

namespace Otiport.API.Mappers.Implementations
{
    public class ProfileItemMapper : IProfileItemMapper
    {
        public ProfileItemModel ToModel(ProfileItemEntity entity)
        {
            return new ProfileItemModel()
            {
                ProfileItemId = entity.Id,
                Title = entity.Title,
                Description = entity.Description
            };
        }

        public ProfileItemEntity ToEntity(ProfileItemModel model)
        {

            return new ProfileItemEntity()
            {
                Id = model.ProfileItemId,
                Title = model.Title,
                Description = model.Description
            };
        }

        public ProfileItemEntity ToEntity(AddProfileItemRequest request)
        {
            return new ProfileItemEntity()
            {
                Title = request.Title,
                Description = request.Description
            };
        }
    }
}
