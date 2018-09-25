using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Otiport.API.Data.Entities.Users;

namespace Otiport.API.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly OtiportDbContext _dbContext;
        private readonly ILogger<IUserRepository> _logger;

        public UserRepository(OtiportDbContext dbContext, ILogger<IUserRepository> logger)
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

        public Task<bool> IsExistsUserAsync(string username, string emailAddress)
        {
            return _dbContext.Users.AnyAsync(x => x.Username == username || x.EmailAddress == emailAddress);
        }

        public async Task<UserEntity> AddAsync(UserEntity entity)
        {
            await _dbContext.Users.AddAsync(entity);
            bool isSuccess = await SaveAsync();

            return isSuccess ? entity : null;
        }
    }
}