using KYN.SwatchService.Business.Contracts;
using KYN.SwatchService.Business.Models;
using KYN.SwatchService.Persistence.Contracts;
using NSubstitute;
using NUnit.Framework;

namespace KYN.SwatchService.API.Tests
{
    [TestFixture]
    public class ControllerTests
    {
        private ISwatchHandler swatchHandler;

        [SetUp]
        public void Setup()
        {
            this.swatchHandler = Substitute.For<ISwatchHandler>();
            this.swatchHandler.Create(default).ReturnsForAnyArgs(new SwatchEntity());
        }

        [Test]
        public CreateShouldDelegateToHandler()
        {

        }

    }
}