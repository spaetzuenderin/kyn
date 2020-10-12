using System;
using System.Threading.Tasks;
using KYN.SwatchService.Business.Contracts;
using KYN.SwatchService.Business.Contracts.Model;
using KYN.SwatchService.Persistence.Contracts.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KYN.SwatchService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SwatchController : ControllerBase
    {
        private ISwatchHandler swatchHandler;

        public SwatchController(ISwatchHandler swatchHandler)
        {
            this.swatchHandler = swatchHandler;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult>Create(Swatch swatch)
        {
            SwatchEntity createdEntity;

            try
            {
                createdEntity = await this.swatchHandler.Create(swatch);
            }
            catch (Exception)
            {
                return BadRequest("Swatch could not be created");
            }

            return Created($"api/SwatchService/{createdEntity.Id.ToString()}", createdEntity);
        }
    }
}