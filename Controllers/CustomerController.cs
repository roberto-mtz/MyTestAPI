using System;
using Microsoft.AspNetCore.Mvc;
using WebAPIStarter.Models;
using System.Collections.Generic;
namespace WebAPIStarter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        public List<Customer> customers;
        public CustomerController(){
            this.customers = new List<Customer> {
                new Customer { Id = 1, FirstName = "Steve", LastName= "Bishop", Email = "steve.bishop@gmail.com"},
                new Customer { Id = 2, FirstName = "Steve", LastName= "Bishop", Email = "steve.bishop@gmail.com"},
                new Customer { Id = 3, FirstName = "Steve", LastName= "Bishop", Email = "steve.bishop@gmail.com"},
            };
        }

        [HttpGet("api/GetCustomer/{id}")]
        public Customer GetCustomer (int id) {
            foreach (Customer customer in this.customers){
                if (customer.Id == id) {
                    return customer;
                }
            }
            return null;
        }

        [HttpGet("api/GetAll")]
        public List<Customer> GetAll() {
            return this.customers;
        }
        //public Object Read(){
        //    var data = new { Id = 1, FirstName = "Steve", LastName= "Bishop", Email = "steve.bishop@gmail.com"};
        //    return data;
        //}

        [HttpPost("api/Post")]
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
