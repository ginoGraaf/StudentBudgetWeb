using System;
using Rest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Rest.Controllers {
    [ApiController]
    [Route("api/User/")]
    public class UserController: ControllerBase {
        [HttpGet]
        public IEnumerable<User> Get() {
            // Get all users
            return new List<User>{
                new User{Id = 0, Name = "Joeri"},
                new User{Id = 42, Name = "Bram"}
                };
        }

        [HttpGet]
        [Route("{Id}")]
        public User Get(int Id) {
            // Get a single user by id
            return new User{Id = Id, Name = "Bram"};
        }

        [HttpPost]
        public User Post(User user) {
            // Create the user
            user.Id = 42;
            return user;
        }

        [HttpPut]
        public User Put(User user) {
            // Do something to update the user at id=user.Id
            return user;
        }

        [HttpDelete]
        [Route("{Id}")]
        public void Delete(int Id) {
            // Delete user
        }
    }
}