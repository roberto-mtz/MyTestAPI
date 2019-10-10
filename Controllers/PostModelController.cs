using System;
using Microsoft.AspNetCore.Mvc;
using WebAPIStarter.Models;
using System.Collections.Generic;

namespace WebAPIStarter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostModelController
    {
        public List<Post> posts = new List<Post> {
                new Post { Id = 1, Author = "Steve", Message= "Hey", Date = "01011992"},
                new Post { Id = 2, Author = "Roberto", Message= "Hey", Date = "01011992"},
                new Post { Id = 3, Author = "Alejandro", Message= "Hey", Date = "01011992"},
            };
        public PostModelController(){
            this.posts = new List<Post> {
                new Post { Id = 1, Author = "Steve", Message= "Hey", Date = "01011992"},
                new Post { Id = 2, Author = "Roberto", Message= "Hey", Date = "01011992"},
                new Post { Id = 3, Author = "Alejandro", Message= "Hey", Date = "01011992"},
            };
        }

        [HttpGet("api/GetPost/{id}")]
        public Post GetCustomer (int id) {
            foreach (Post post in this.posts){
                if (post.Id == id) {
                    return post;
                }
            }
            return null;
        }

        [HttpGet]
        public List<Post> GetAll() {
            return this.posts;
        }

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