using System.Threading.Tasks;
using KYN.SwatchService.Persistence.Contracts.Entities;

namespace KYN.SwatchService.Persistence.Contracts.Context
{
    public interface IDataContext
    {
         Task<SwatchEntity> Add(SwatchEntity swatchEntity);
    }
}