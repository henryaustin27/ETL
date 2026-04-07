using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WelcomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Welcome to SimpleWebApi" });
        }
    }
}