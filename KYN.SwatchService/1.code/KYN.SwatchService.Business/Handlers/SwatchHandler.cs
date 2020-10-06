using System.Threading.Tasks;
using KYN.SwatchService.Business.Contracts;
using KYN.SwatchService.Business.Contracts.Model;
using KYN.SwatchService.Persistence.Contracts.Context;
using KYN.SwatchService.Persistence.Contracts.Entities;
using KYN.SwatchService.Persistence.Contracts.Repositories;

namespace KYN.SwatchService.Business.Handlers
{
    public class SwatchHandler : ISwatchHandler
    {
        private readonly  ISwatchRepository swatchRepository;
        private readonly ISwatchMapper swatchMapper;
        public async Task<SwatchEntity> Create(Swatch swatch)
        {
            SwatchEntity swatchEntity = this.swatchMapper.Map(swatch);

            return await this.swatchRepository.Create(swatchEntity);
        }
    }
}
