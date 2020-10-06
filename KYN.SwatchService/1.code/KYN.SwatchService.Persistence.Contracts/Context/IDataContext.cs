using KYN.SwatchService.Persistence.Contracts.Entities;

namespace KYN.SwatchService.Persistence.Contracts.Context
{
    public interface IDataContext
    {
         void Add(SwatchEntity swatchEntity);
    }
}