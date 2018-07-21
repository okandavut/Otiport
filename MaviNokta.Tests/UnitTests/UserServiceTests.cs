﻿using System;
using System.Threading.Tasks;
using AutoFixture;
using AutoMapper;
using FluentAssertions;
using MaviNokta.Entities.Users;
using MaviNokta.Models.Users;
using MaviNokta.Repository;
using MaviNokta.Services.Implementations;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace MaviNokta.Tests.UnitTests
{
    public class UserServiceTests : TestBase
    {
        private readonly Mock<ILogger<UserService>> _loggerMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<IRepository<UserEntity, Guid>> _userRepositoryMock;
        public UserServiceTests()
        {
            _userRepositoryMock = MockFor<IRepository<UserEntity, Guid>>();
            _mapperMock = MockFor<IMapper>();
            _loggerMock = MockFor<ILogger<UserService>>();
        }

        [Fact]
        public void Should_Create_User_Not_Null_Tests()
        {
            var userEntity = FixtureRepository.Create<UserEntity>();

            _userRepositoryMock.Setup(x => x.Add(userEntity)).Returns(Task.FromResult(true));
            var userService = new UserService(_userRepositoryMock.Object, _mapperMock.Object, _loggerMock.Object);
            var result = userService.CreateUser(new CreateUserModel()
            {
                Password = "12345678",
                Username = "testuser",
                EmailAddress = "testuser@mavinokta.com"
            }).Result;

            result.Should().NotBeNull();
        }
    }
}