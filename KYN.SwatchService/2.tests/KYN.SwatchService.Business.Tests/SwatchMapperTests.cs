using System;
using KYN.SwatchService.Business.Contracts;
using KYN.SwatchService.Business.Contracts.Model;
using KYN.SwatchService.Business.Mappers;
using KYN.SwatchService.Persistence.Contracts.Entities;
using NUnit.Framework;

namespace KYN.SwatchService.Business.Tests
{
    [TestFixture]
    public class SwatchMapperTests
    {
        private ISwatchMapper swatchMapper;
        [SetUp]
        public void Setup()
        {
            this.swatchMapper = new SwatchMapper();
        }

        //mapping from model to entity

        [Test]
        public void MapShouldMapSwatchIdToSwatchEntity()
        {
            Swatch source = new Swatch {Id = Guid.NewGuid()};

            SwatchEntity result = this.swatchMapper.Map(source);

            Assert.AreEqual(result.Id, source.Id);
        }

        [Test]
        public void MapShouldMapSwatchNumberOfStitchesToEntity()
        {
            Swatch source = new Swatch {NumberOfStitches = 11};

            SwatchEntity result = this.swatchMapper.Map(source);

            Assert.AreEqual(result.NumberOfStitches, source.NumberOfStitches);
        }

        [Test]
        public void MapShouldMapSwatchNumberOfRowsToEntity()
        {
            Swatch source = new Swatch { NumberOfRows = 11 };

            SwatchEntity result = this.swatchMapper.Map(source);

            Assert.AreEqual(result.NumberOfRows, source.NumberOfRows);
        }

        [Test]
        public void MapShouldMapSwatchNameToEntity()
        {
            Swatch source = new Swatch { Name = "my Swatch" };

            SwatchEntity result = this.swatchMapper.Map(source);

            Assert.AreEqual(result.Name, source.Name);
        }

        [Test]
        public void MapShouldMapSwatchStitchpatternToEntity()
        {
            Swatch source = new Swatch { Stitchpattern = "garter stitch" };

            SwatchEntity result = this.swatchMapper.Map(source);

            Assert.AreEqual(result.Stitchpattern, source.Stitchpattern);
        }

        [Test]
        public void MapShouldMapSwatchYarnToEntity()
        {
            Swatch source = new Swatch { Yarn = "Regia Sockenwolle" };

            SwatchEntity result = this.swatchMapper.Map(source);

            Assert.AreEqual(result.Yarn, source.Yarn);
        }

        [Test]
        public void MapShouldMapSwatchNeedleSizeToEntity()
        {
            Swatch source = new Swatch { NeedleSize = 3.0 };

            SwatchEntity result = this.swatchMapper.Map(source);

            Assert.AreEqual(result.NeedleSize, source.NeedleSize);
        }

        //mapping from entity to model
        [Test]
        public void MapShouldMapSwatchEntityIdToModel()
        {
            SwatchEntity source = new SwatchEntity {Id = Guid.NewGuid()};

            Swatch result = this.swatchMapper.Map(source);

            Assert.AreEqual(result.Id, source.Id);
        }

        [Test]
        public void MapShouldMapSwatchEntityNumberOfStitchesToModel()
        {
            SwatchEntity source = new SwatchEntity { NumberOfStitches = 1};

            Swatch result = this.swatchMapper.Map(source);

            Assert.AreEqual(result.NumberOfStitches, source.NumberOfStitches);
        }

        [Test]
        public void MapShouldMapSwatchEntityNumberOfRowsToModel()
        {
            SwatchEntity source = new SwatchEntity { NumberOfRows = 11};

            Swatch result = this.swatchMapper.Map(source);

            Assert.AreEqual(result.NumberOfRows, source.NumberOfRows);
        }

        [Test]
        public void MapShouldMapSwatchEntityNameToModel()
        {
            SwatchEntity source = new SwatchEntity { Name = "Maschenprobe"};

            Swatch result = this.swatchMapper.Map(source);

            Assert.AreEqual(result.Name, source.Name);
        }

        [Test]
        public void MapShouldMapSwatchEntityStichtpatternToModel()
        {
            SwatchEntity source = new SwatchEntity { Stitchpattern = "kraus rechts" };

            Swatch result = this.swatchMapper.Map(source);

            Assert.AreEqual(result.Stitchpattern, source.Stitchpattern);
        }

        [Test]
        public void MapShouldMapSwatchEntityYarnToModel()
        {
            SwatchEntity source = new SwatchEntity { Yarn = "Fairalpaka DK" };

            Swatch result = this.swatchMapper.Map(source);

            Assert.AreEqual(result.Yarn, source.Yarn);
        }

        [Test]
        public void MapShouldMapSwatchEntityNeedleSizeToModel()
        {
            SwatchEntity source = new SwatchEntity { NeedleSize = 7.0 };

            Swatch result = this.swatchMapper.Map(source);

            Assert.AreEqual(result.NeedleSize, source.NeedleSize);
        }
    }

}