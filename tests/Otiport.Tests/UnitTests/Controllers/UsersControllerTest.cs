using Moq;
using Otiport.API.Controllers;
using Otiport.API.Services;
using System.Threading.Tasks;
using Xunit;
using AutoFixture;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Otiport.API.Contract.Response.Users;
using Otiport.API.Contract.Request.Users;

namespace Otiport.Tests.UnitTests.Controllers
{

    public class UsersControllerTest : TestBase
    {
        private readonly UsersController usersController;
        private readonly Mock<IUserService> userServiceMock;
        public UsersControllerTest()
        {
            userServiceMock = MockFor<IUserService>();
            usersController = new UsersController(userServiceMock.Object);
        }
        [Fact]
        public async Task Login_Should_Return_Success()
        {
            //Arrange
            var loginRequest = FixtureRepository.Create<LoginRequest>();
            var loginResponse = FixtureRepository.Create<LoginResponse>();
            userServiceMock.Setup(x => x.LoginAsync(loginRequest)).Returns(Task.FromResult<LoginResponse>(loginResponse));

            //Act
            var result = await usersController.Login(loginRequest);
            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<ObjectResult>();
            var response = (ObjectResult)result;
            response.StatusCode.Should().Be((int)HttpStatusCode.OK);
        }
    }
}
