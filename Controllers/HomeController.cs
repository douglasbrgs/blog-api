using Blog.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Get([FromServices] IConfiguration config)
        {
            var enviroment = config.GetValue<string>("Env");
            return Ok(new {
                enviroment
            });
        }
    }
}
