using System.Threading.Tasks;
using KYN.SwatchService.Persistence.Contracts.Entities;

namespace KYN.SwatchService.Persistence.Contracts.Repositories
{
    public interface ISwatchRepository
    {
        Task<SwatchEntity> Create(SwatchEntity swatchEntity);
    }
}