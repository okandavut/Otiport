using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Otiport.API.Data;
using Otiport.API.Data.Entities.ProfileItem;

namespace Otiport.API.Repositories.Implementations
{
    public class ProfileItemRepository : IProfileItemRepository
    {
        private readonly OtiportDbContext _dbContext;
        private readonly ILogger<IProfileItemRepository> _logger;

        public ProfileItemRepository(OtiportDbContext dbContext, ILogger<IProfileItemRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }

        public async Task<bool> SaveAsync()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Something went wrong");
                return false;
            }
        }

        public async Task<IEnumerable<ProfileItemEntity>> GetProfileItemsAsync()
        {
            return await _dbContext.ProfileItems.ToListAsync();

        }

        public async Task<bool> AddProfileItemAsync(ProfileItemEntity entity)
        {
            await _dbContext.ProfileItems.AddAsync(entity);
            return await SaveAsync();
        }

        public async Task<bool> DeleteProfileItemAsync(ProfileItemEntity entity)
        {
            _dbContext.ProfileItems.Remove(entity);
            return await SaveAsync();
        }

        public async Task<ProfileItemEntity> GetProfileItemById(int id)
        {
            var profileItemEntity = await _dbContext.ProfileItems.FindAsync(id);
            return profileItemEntity;
        }
        public async Task<bool> UpdateProfileItemsAsync(ProfileItemEntity entity)
        {
            _dbContext.ProfileItems.Update(entity);
            return await SaveAsync();
        }
    }
}
