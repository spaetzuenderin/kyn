using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KYN.SwatchService.API.Controllers.Base
{
    //Base class for controllers.
    [Authorize]
    [ApiController]
    public abstract class BaseController : ControllerBase { }
}