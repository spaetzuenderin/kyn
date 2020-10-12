using System.Threading.Tasks;
using KYN.SwatchService.Persistence.Contracts.Context;
using KYN.SwatchService.Persistence.Contracts.Entities;

namespace KYN.SwatchService.Persistence.Context
{
    public class DataContext : IDataContext
    {
        public async Task<SwatchEntity> Add(SwatchEntity swatchEntity)
        {
            throw new System.NotImplementedException();
        }
    }
}