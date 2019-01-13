using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Data.Entities.ProfileItem;

namespace Otiport.API.Repositories
{
    public interface IProfileItemRepository
    {
        Task<IEnumerable<ProfileItemEntity>> GetProfileItemsAsync();
        Task<bool> AddProfileItemAsync(ProfileItemEntity entity);
        Task<bool> DeleteProfileItemAsync(ProfileItemEntity entity);
        Task<ProfileItemEntity> GetProfileItemById(int id);
        Task<bool> UpdateProfileItemsAsync(ProfileItemEntity entity);
    }
}
