using System;
using Rest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using DataAccessLibrary;

namespace Rest.Controllers {
    [ApiController]
    [Route("api/User/")]
    public class UserController: ControllerBase {
        
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<User> Get() {
            // Get all users
            return users;
        }

        [HttpGet]
        [Route("{Id}")]
        public User Get(int Id) {
            // Get a single user by id
            return users.FirstOrDefault(u => u.Id == Id);
        }

        [HttpPost]
        public User Post([FromBody] User user) {
            // Create the user
            user.Id = Index;
            Index++;
            users.Add(user);
            return user;
        }

        [HttpPut]
        public User Put([FromBody] User user) {
            // Do something to update the user at id=user.Id
            var userToRemove = users.FirstOrDefault(u => u.Id == user.Id);
            users.Remove(userToRemove);
            users.Add(user);
            return user;
        }

        [HttpDelete]
        [Route("{Id}")]
        public void Delete(int Id) {
            // Delete user
            var userToRemove = users.FirstOrDefault(user => user.Id == Id);
            users.Remove(userToRemove);
        }
    }
}