using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TodoApp.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DenemeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Merhaba! Backend çalışıyor 🚀");
        }
    }
}
