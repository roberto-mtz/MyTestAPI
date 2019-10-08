using Microsoft.AspNetCore.Mvc;

namespace WebAPIStarter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyTestController : ControllerBase
    {
        [HttpGet]
        public string Get(){
            return "Hello World from MyTest!";
        }
    }
}