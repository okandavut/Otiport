using System;
using System.Net;
using Microsoft.Extensions.Logging;
using Otiport.API.Extensions;
using Otiport.API.Repositories;
using System.Threading.Tasks;
using Otiport.API.Contract.Request.Users;
using Otiport.API.Contract.Response.Users;
using Otiport.API.Mappers;

namespace Otiport.API.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly IUserMapper _userMapper;
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository, IUserMapper userMapper, ILogger<UserService> logger)
        {
            _userRepository = userRepository;
            _userMapper = userMapper;
            _logger = logger;
        }

        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            var response = new CreateUserResponse();
            request.UserModel.Password = request.UserModel.Password.Hash(HashType.SHA256);
            bool isExists =
                await _userRepository.IsExistsUserAsync(request.UserModel.Username, request.UserModel.EmailAddress);

            if (!isExists)
            {
                //TODO: Create User
                var userEntity = _userMapper.ToEntity(request.UserModel);

                userEntity = await _userRepository.AddAsync(userEntity);
                if (userEntity != null && userEntity.Id != Guid.Empty)
                {
                    response.StatusCode = (int) HttpStatusCode.Created;
                    return response;
                }

                //TODO: Add Logging
                _logger.LogWarning("");
            }

            response.StatusCode = (int) HttpStatusCode.InternalServerError;
            return response;
        }
    }
}