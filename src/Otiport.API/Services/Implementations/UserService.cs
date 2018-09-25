using AutoMapper;
using Microsoft.Extensions.Logging;
using Otiport.API.Data.DTOs.Users;
using Otiport.API.Data.Entities.Users;
using Otiport.API.Extensions;
using Otiport.API.Models.Users;
using Otiport.API.Repositories;
using System;
using System.Threading.Tasks;

namespace Otiport.API.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly IMapper _mapper;
        private readonly IRepository<UserEntity, Guid> _userRepository;
        public UserService(IRepository<UserEntity, Guid> userRepository, IMapper mapper, ILogger<UserService> logger)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<UserDTO> CreateUser(CreateUserModel model)
        {
            model.Password = model.Password.Hash(HashType.SHA256);
            bool isExists = await _userRepository.ExistsByDefault(x =>
                x.Username == model.Username || x.EmailAddress == model.EmailAddress);

            if (!isExists)
            {
                //TODO: Create User
                var entity = new UserEntity()
                {
                    Username = model.Username,
                    Password = model.Password,
                    EmailAddress = model.EmailAddress
                };

                bool isSuccess = await _userRepository.Add(entity);
                if (isSuccess)
                {
                    return _mapper.Map<UserEntity, UserDTO>(entity);
                }
                else
                {
                    //TODO: Add Logging
                    _logger.LogWarning("");
                }
            }

            return null;
        }
    }
}