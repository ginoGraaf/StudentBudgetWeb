using System;
using Microsoft.AspNetCore.Mvc;

namespace Rest.Controllers {
    [ApiController]
    [Route("api/User/")]
    public class UserController: ControllerBase {
        [HttpGet]
        public string Get() {
            return "Hello World!";
        }

        [HttpGet]
        [Route("{Id}")]
        public string Get(int Id) {
            return Id.ToString();
        }

        [HttpPost]
        [Consumes("application/json")]
        public string Post(string user) {
            return "ID + " + user;
        }
    }
}