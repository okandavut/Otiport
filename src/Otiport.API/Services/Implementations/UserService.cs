using System;
using System.Net;
using Microsoft.Extensions.Logging;
using Otiport.API.Extensions;
using Otiport.API.Repositories;
using System.Threading.Tasks;
using Otiport.API.Contract.Request.Users;
using Otiport.API.Contract.Response.Users;
using Otiport.API.Mappers;
using Otiport.API.Providers;
using Microsoft.Extensions.Configuration;
using Otiport.API.Common;

namespace Otiport.API.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly IUserMapper _userMapper;
        private readonly IUserRepository _userRepository;
        private readonly ITokenProvider _tokenProvider;
        private readonly IConfiguration _configuration;

        public UserService(IUserRepository userRepository, IUserMapper userMapper, ILogger<UserService> logger,
            ITokenProvider tokenProvider, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _userMapper = userMapper;
            _logger = logger;
            _tokenProvider = tokenProvider;
            _configuration = configuration;
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
                userEntity.UserGroupId = _configuration.GetValue<int>(Contants.DefaultUserGroupId);

                userEntity = await _userRepository.AddAsync(userEntity);
                if (userEntity != null && userEntity.Id != Guid.Empty)
                {
                    response.StatusCode = (int)HttpStatusCode.Created;
                    return response;
                }
                //TODO: Add Logging
                _logger.LogWarning("");
            }
            response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return response;
        }

        public async Task<LoginResponse> LoginAsync(LoginRequest request)
        {
            var response = new LoginResponse();

            request.Password = request.Password.Hash(HashType.SHA256);
            var userEntity = await _userRepository.GetUserByCredentialsAsync(request.EmailAddress, request.Password);
            if (userEntity == null)
            {
                //TODO (peacecwz): Logging
                response.StatusCode = (int)HttpStatusCode.NotFound;
                return response;
            }

            response.AccessToken =
                await _tokenProvider.GenerateTokenAsync(userEntity.Id, userEntity.EmailAddress, userEntity.UserGroupId);
            response.StatusCode = (int)HttpStatusCode.OK;
            return response;
        }
    }
}