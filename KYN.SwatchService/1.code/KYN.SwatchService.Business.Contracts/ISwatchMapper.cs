using KYN.SwatchService.Business.Contracts.Model;
using KYN.SwatchService.Persistence.Contracts.Entities;

namespace KYN.SwatchService.Business.Contracts
{
    public interface ISwatchMapper
    {
        SwatchEntity Map(Swatch swatch);
        Swatch Map(SwatchEntity swatchEntity);

    }
}