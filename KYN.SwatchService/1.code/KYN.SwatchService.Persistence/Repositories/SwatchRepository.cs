using KYN.SwatchService.Persistence.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KYN.SwatchService.Persistence.Contracts.Context;
using KYN.SwatchService.Persistence.Contracts.Entities;

namespace KYN.SwatchService.Persistence.Repositories
{
    public class SwatchRepository : ISwatchRepository
    {
        private IDataContext dataContext;

        public SwatchRepository(IDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public Task<SwatchEntity> Create(SwatchEntity swatchEntity)
        {
            this.dataContext.Add(swatchEntity);
        }
    }
}
}
