using KYN.SwatchService.API.Controllers;
using KYN.SwatchService.API.Controllers.Base;
using KYN.SwatchService.Business.Contracts;
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
        public void CreateShouldDelegateToHandler()
        {
        }
    }
}