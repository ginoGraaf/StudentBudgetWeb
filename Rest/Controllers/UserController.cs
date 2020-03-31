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
            return new List<User>{
                new User{Id = 0, Name = "Joeri"},
                new User{Id = 42, Name = "Bram"}
                };
        }

        [HttpGet]
        [Route("{Id}")]
        public User Get(int Id) {
            return new User{Id = Id, Name = "Bram"};
        }

        [HttpPost]
        public User Post(User user) {
            user.Id = 42;
            return user;
        }
    }
}