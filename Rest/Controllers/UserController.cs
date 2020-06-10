using System;
using Rest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using DataAccessLibrary;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Rest.Controllers {
    [ApiController]
    [Route("api/User/")]
    [Route("api/Users/")]

    public class UserController: ControllerBase {
        
        private readonly ApplicationContext _context;

        public UserController(ApplicationContext context)
        {
            this._context = context;
        }

        [HttpPost]
        [Route("authenticate")]
        public async Task<ActionResult<User>> Authenticate(User userInfo)
        {
            try {
                var user = await FindByEmail(userInfo.Email); 
                if(user.Password == userInfo.Password)
                {
                    return user;
                }
                else
                {
                    return Unauthorized();
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return Unauthorized();
            }

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers() {
            return await _context.Users.ToListAsync();
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<ActionResult<User>> GetUser(int Id) {
            var user = await _context.Users.FindAsync(Id);
            if (user == null) {
                return NotFound();
            }
            return user;
        }

        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user) {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> PutUser(int Id, User user)
        {
            if (Id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
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
            var user = await _context.Users.FindAsync(Id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private bool UserExists(int Id) {
            return _context.Users.Any(e => e.Id == Id);
        }

        private async Task<User> FindByEmail(string email)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Email == email );
            return user;
        }
    }
}