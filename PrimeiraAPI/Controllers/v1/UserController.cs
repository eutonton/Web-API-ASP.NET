using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;


namespace PrimeiraAPI.Controllers.v1
{
    [ApiVersion(1.0)]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("User V1");
        }
    }
}
//https://localhost:7249/api/v1/user