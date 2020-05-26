using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccessLibrary;
using Microsoft.EntityFrameworkCore;

namespace Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavingTargetController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public SavingTargetController(ApplicationContext context)
        {
            this._context = context;
        }
        // GET: api/SavingTarget/5
        [HttpGet("{id}", Name = "Get")]
        public SavingGoalsModel Get(int id)
        {
            return new SavingGoalsModel();
        }

        // POST: api/SavingTarget
        [HttpPost]
        public void Post([FromBody] SavingGoalsModel savingTarget)
        {
            
        }

        // PUT: api/SavingTarget/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SavingGoalsModel savingTarget)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
