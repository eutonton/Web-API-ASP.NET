using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI.Controllers.v2
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("User V2");
        }
    }
}
