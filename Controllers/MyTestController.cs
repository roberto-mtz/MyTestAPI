using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WebAPIStarter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyTestController : ControllerBase
    {
        string appName = "";
        public MyTestController(IConfiguration config) {
            appName = config.GetValue<string>("applicationName");
        }

        [HttpGet]
        public string Get(){
            return "Hello World from " + appName;
        }
    }
}