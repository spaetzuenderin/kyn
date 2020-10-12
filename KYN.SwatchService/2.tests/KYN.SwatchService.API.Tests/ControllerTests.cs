using System;
using System.Threading.Tasks;
using KYN.SwatchService.API.Controllers;
using KYN.SwatchService.Business.Contracts;
using KYN.SwatchService.Business.Contracts.Model;
using KYN.SwatchService.Persistence.Contracts.Entities;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;

namespace KYN.SwatchService.API.Tests
{
    [TestFixture]
    public class ControllerTests
    {
        private ISwatchHandler swatchHandler;
        private SwatchController swatchController;



        [SetUp]
        public void SetUp()
        {
            this.swatchHandler = Substitute.For<ISwatchHandler>();
            this.swatchController = new SwatchController(swatchHandler);
        }

        [Test]
        public async Task CreateShouldDelegateToHandler()
        {
            Swatch swatch = new Swatch(29, 36);
            
            await this.swatchController.Create(swatch);

            await this.swatchController.ReceivedWithAnyArgs().Create(default);
        }

        [Test]
        public async Task CreateShouldReturnBadRequestOnException()
        {
            this.swatchHandler.Create(default).ThrowsForAnyArgs<Exception>();

            Swatch swatch = new Swatch();

            SwatchEntity actionResult = await this.swatchHandler.Create(swatch);

            Assert.True(actionResult is BadRequestResult);
        }


    }
}