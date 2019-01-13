using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Contract.Models;
using Otiport.API.Contract.Request.ProfileItems;
using Otiport.API.Data.Entities.ProfileItem;

namespace Otiport.API.Mappers
{
    public interface IProfileItemMapper
    {
        ProfileItemModel ToModel(ProfileItemEntity entity);
        ProfileItemEntity ToEntity(ProfileItemModel model);
        ProfileItemEntity ToEntity(AddProfileItemRequest request);
    }
}
