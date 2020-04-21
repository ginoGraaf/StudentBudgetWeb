using System;
using Rest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using DataAccessLibrary;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Rest.Controllers {
    [ApiController]
    [Route("api/User/")]
    [Route("api/Users/")]
    public class UserController: ControllerBase {
        
        private readonly ApplicationContext context;

        public UserController(ApplicationContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers() {
            // Get all users
            return await context.Users.ToListAsync();
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<ActionResult<User>> GetUser(int Id) {
            // Get a single user by id
            var user = await context.Users.FindAsync(Id);
            if (user == null) {
                return NotFound();
            }
            return user;
        }

        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user) {
            // Create the user
            context.Users.Add(user);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> PutUser(int Id, User user) {
            // Do something to update the user at id=user.Id
            if (Id != user.Id) {
                return BadRequest();
            }

            context.Entry(user).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<User>> DeleteUser(int Id) {
            // Delete user
            var user = await context.Users.FindAsync(Id);
            if (user == null)
            {
                return NotFound();
            }

            context.Users.Remove(user);
            await context.SaveChangesAsync();

            return user;
        }

        private bool UserExists(int Id) {
            return context.Users.Any(e => e.Id == Id);
        }
    }
}