

using System.Threading.Tasks;
using KYN.SwatchService.Business.Contracts.Model;
using KYN.SwatchService.Persistence.Contracts.Entities;

namespace KYN.SwatchService.Business.Contracts
{

    public interface ISwatchHandler
    {
        Task<SwatchEntity> Create(Swatch swatch);

    }
}