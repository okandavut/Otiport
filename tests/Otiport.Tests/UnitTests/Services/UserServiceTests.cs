using System;
using System.Threading.Tasks;
using AutoFixture;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Otiport.API.Contract.Request.Users;
using Otiport.API.Contract.Response.Users;
using Otiport.API.Data.Entities.Users;
using Otiport.API.Mappers;
using Otiport.API.Providers;
using Otiport.API.Repositories;
using Otiport.API.Services;
using Otiport.API.Services.Implementations;
using Xunit;

namespace Otiport.Tests.UnitTests.Services
{
    public class UserServiceTests : TestBase
    {
        private readonly Mock<ILogger<UserService>> _loggerMock;
        private readonly Mock<IUserMapper> _mapperMock;
        private readonly Mock<IUserRepository> _userRepositoryMock;
        private readonly IUserService _userService;
        private readonly Mock<ITokenProvider> _tokenProviderMock;

        public UserServiceTests()
        {
            _userRepositoryMock = MockFor<IUserRepository>();
            _mapperMock = MockFor<IUserMapper>();
            _loggerMock = MockFor<ILogger<UserService>>();
            _tokenProviderMock = MockFor<ITokenProvider>();
            _userService = new UserService(_userRepositoryMock.Object, _mapperMock.Object, _loggerMock.Object,
                _tokenProviderMock.Object);
        }

        [Fact]
        public async Task LoginAsync_Should_Return_Result()
        {
            //Arrange
            string accessToken = Guid.NewGuid().ToString();
            var loginRequest = FixtureRepository.Create<LoginRequest>();
            var userEntity = FixtureRepository.Build<UserEntity>().Without(x => x.Patients).Without(x => x.UserGroup)
                .Create();
            _userRepositoryMock
                .Setup(x => x.GetUserByCredentialsAsync(loginRequest.EmailAddress, loginRequest.Password))
                .Returns(Task.FromResult(userEntity));
            _tokenProviderMock
                .Setup(x => x.GenerateTokenAsync(userEntity.Id, userEntity.EmailAddress, userEntity.UserGroupId))
                .Returns(Task.FromResult(accessToken));

            //Act
            var result = await _userService.LoginAsync(loginRequest);

            //Assert
            result.IsSuccess.Should().BeTrue();
            result.AccessToken.Should().NotBeNullOrEmpty();
            result.AccessToken.Should().Be(accessToken);
        }
        
        [Fact]
        public async Task LoginAsync_Should_Return_NotFound_When_UserEntity_Is_Null()
        {
            //Arrange
            string accessToken = Guid.NewGuid().ToString();
            var loginRequest = FixtureRepository.Create<LoginRequest>();
            _userRepositoryMock
                .Setup(x => x.GetUserByCredentialsAsync(loginRequest.EmailAddress, loginRequest.Password))
                .Returns(Task.FromResult(default(UserEntity)));

            //Act
            var result = await _userService.LoginAsync(loginRequest);

            //Assert
            result.IsSuccess.Should().BeFalse();
            result.AccessToken.Should().BeNullOrEmpty();
        }
    }
}