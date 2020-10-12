using KYN.SwatchService.Business.Contracts;
using KYN.SwatchService.Business.Contracts.Model;
using KYN.SwatchService.Persistence.Contracts.Entities;

namespace KYN.SwatchService.Business.Mappers
{
    public class SwatchMapper : ISwatchMapper
    {
        public SwatchEntity Map(Swatch swatch)
        {
            return new SwatchEntity
            {
                Id = swatch.Id,
                NumberOfStitches = swatch.NumberOfStitches,
                NumberOfRows = swatch.NumberOfRows,
                Name = swatch.Name,
                Stitchpattern = swatch.Stitchpattern,
                Yarn = swatch.Yarn,
                NeedleSize = swatch.NeedleSize
            };
        }

        public Swatch Map(SwatchEntity swatchEntity)
        {
            return new Swatch
            {
                Id = swatchEntity.Id,
                NumberOfStitches = swatchEntity.NumberOfStitches,
                NumberOfRows = swatchEntity.NumberOfRows,
                Name = swatchEntity.Name,
                Stitchpattern = swatchEntity.Stitchpattern,
                Yarn = swatchEntity.Yarn,
                NeedleSize = swatchEntity.NeedleSize
            };
        }
    }
}