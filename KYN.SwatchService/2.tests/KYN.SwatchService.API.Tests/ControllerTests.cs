using System.Threading.Tasks;
using KYN.SwatchService.API.Controllers;
using KYN.SwatchService.API.Controllers.Base;
using KYN.SwatchService.Business.Contracts;
using KYN.SwatchService.Business.Contracts.Model;
using NSubstitute;
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
        public void ControllerShouldDeriveFromBaseController()
        {
            Assert.IsInstanceOf<BaseController>(this.swatchController);
        }

        [Test]
        public async Task CreateShouldDelegateToHandler()
        {
            Swatch swatch = new Swatch(29, 36);
            
            await this.swatchController.Create(swatch);

            await this.swatchController.ReceivedWithAnyArgs().Create(default);
        }
    }
}