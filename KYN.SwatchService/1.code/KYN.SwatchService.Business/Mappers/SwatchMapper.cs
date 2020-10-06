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

            };
        }

        public Swatch Map(SwatchEntity swatchEntity)
        {
            return new Swatch
            {

            };
        }
    }
}