using Microsoft.AspNetCore.Mvc;

namespace WebApiLaeyr.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ErrorController : ControllerBase
    {
        [HttpGet]
        public string Error()
        {
            return "Internal server error";
        }
    }
}