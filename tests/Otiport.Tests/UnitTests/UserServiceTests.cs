﻿using System;
using System.Threading.Tasks;
using AutoFixture;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Moq;
using Otiport.API.Data.Entities.Users;
using Otiport.API.Repositories;
using Otiport.API.Services.Implementations;
using Xunit;

namespace Otiport.Tests.UnitTests
{
    public class UserServiceTests : TestBase
    {
        private readonly Mock<ILogger<UserService>> _loggerMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<IUserRepository> _userRepositoryMock;

        public UserServiceTests()
        {
            _userRepositoryMock = MockFor<IUserRepository>();
            _mapperMock = MockFor<IMapper>();
            _loggerMock = MockFor<ILogger<UserService>>();
        }

        [Fact]
        public void Should_Create_User_Not_Null_Tests()
        {
            
        }
    }
}