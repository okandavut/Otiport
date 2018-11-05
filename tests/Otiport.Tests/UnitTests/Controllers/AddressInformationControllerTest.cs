using System.Collections.Generic;
using Moq;
using Otiport.API.Controllers;
using Otiport.API.Services;
using System.Threading.Tasks;
using Xunit;
using AutoFixture;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Otiport.API.Contract.Request.Common;
using Otiport.API.Contract.Response.Common;
using Otiport.API.Data.Entities.AddressInformations;

namespace Otiport.Tests.UnitTests.Controllers
{
    public class AddressInformationControllerTest : TestBase
    {
        private readonly AddressInformationsController addressInformationController;
        private readonly Mock<IAddressInformationService> addressServiceMock;

        public AddressInformationControllerTest()
        {
            addressServiceMock = MockFor<IAddressInformationService>();
            addressInformationController = new AddressInformationsController(addressServiceMock.Object);
        }

        [Fact]
        public async Task GetCountries_Should_Return_Value()
        {
            //Arrange
            var getCountriesResponse = FixtureRepository.Create<GetCountriesResponse>();
            addressServiceMock.Setup(x => x.GetCountriesAsync()).Returns(Task.FromResult<GetCountriesResponse>(getCountriesResponse));
            //Act
            var result = await addressInformationController.GetCountries();
            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<ObjectResult>();
            var response = (ObjectResult)result;
            response.StatusCode.Should().Be((int)HttpStatusCode.OK);
        }

        [Fact]
        public async Task GetCities_Should_Return_Value()
        {
            //Arrange
            var getCitiesResponse = FixtureRepository.Create<GetCitiesResponse>();
            var getCitiesRequest = FixtureRepository.Create<GetCitiesRequest>();
            addressServiceMock.Setup(x => x.GetCitiesAsync(getCitiesRequest)).Returns(Task.FromResult<GetCitiesResponse>(getCitiesResponse));
            //Act
            var result = await addressInformationController.GetCities(getCitiesRequest);
            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<ObjectResult>();
            var response = (ObjectResult)result;
            response.StatusCode.Should().Be((int)HttpStatusCode.OK);
        }
    }
}
