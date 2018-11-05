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
            var getCountriesRequest = FixtureRepository.Create<GetCountriesRequest>();
            var getCountriesResponse = FixtureRepository.Create<GetCountriesResponse>();
            addressServiceMock.Setup(x => x.GetCountriesAsync(getCountriesRequest)).Returns(Task.FromResult<GetCountriesResponse>(getCountriesResponse));
            //Act
            var result = await addressInformationController.GetCountries(getCountriesRequest);
            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<GetCountriesResponse>();
            var response = (GetCountriesResponse)result;
            response.Should().NotBe(null);
        }
    }
}
