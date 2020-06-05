using Microsoft.AspNetCore.Mvc;

namespace WebApiLaeyr.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DevController : ControllerBase
    {
        [HttpGet("error")]
        public void Get()
        {
            var x = 0;
            var y = 1 / x;
        }
    }
}