using System.Threading.Tasks;
using KYN.SwatchService.Business.Contracts;
using KYN.SwatchService.Business.Models;
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
        public async Task<IActionResult> Create(Swatch swatch)
        {
            SwatchEntity swatchEntity;

            try
            {


                swatchEntity = await this.swatchHandler.Create(swatch);
            }
            catch (Exception)
            {
                return BadRequest();
            }

            return Created($"api/SwatchService/{swatchEntity.Id.ToString()}", swatchEntity);
        }
    }
}