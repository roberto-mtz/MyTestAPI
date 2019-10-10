using System;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIStarter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public string Get(){
            return "Get";
        }
        //public Object Read(){
        //    var data = new { Id = 1, FirstName = "Steve", LastName= "Bishop", Email = "steve.bishop@gmail.com"};
        //    return data;
        //}

        [HttpPost]
        public string Post() {
            return "Post";
        }

        [HttpPut]
        public string Put(){
            return "Put";
        }

        [HttpDelete]
        public string Delete(){
            return "Delete";
        }

    }   
}