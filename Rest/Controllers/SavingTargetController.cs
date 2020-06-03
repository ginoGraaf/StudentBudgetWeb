using System;
using Rest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using DataAccessLibrary;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Rest.Controllers
{

    [ApiController]
    [Route("api/SavingTarget")]
    public class SavingTargetController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public SavingTargetController(ApplicationContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SavingGoalsModel>>> GetSavingTargets()
        {
            List<SavingGoalsModel> Allgoals = new List<SavingGoalsModel>();
            Allgoals= await _context.SavingGoals.ToListAsync();
            return Allgoals;
        }

        // GET: api/SavingTarget/5
        [HttpGet]
        [Route("{Id}")]
        public async Task<ActionResult<SavingGoalsModel>> Get(int id)
        {
            var savingsGoal =await _context.SavingGoals.FindAsync(id);
            return savingsGoal;
        }

        // POST: api/SavingTarget
        [HttpPost]
        public async Task<ActionResult<SavingGoalsModel>> Post([FromBody] SavingGoalsModel savingTarget)
        {
            _context.SavingGoals.Add(savingTarget);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetSavingTargets", new SavingGoalsModel() );
        }

        // PUT: api/SavingTarget/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int UserId, [FromBody] SavingGoalsModel savingTarget)
        {
            if(savingTarget.UserID!=UserId)
            {
                BadRequest();
            }
            _context.Entry(savingTarget).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GoalExists(savingTarget.ID))
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

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SavingGoalsModel>> Delete(int id)
        {
            var savingsGoal= await _context.SavingGoals.FindAsync(id);
            if (savingsGoal==null)
            {
                return NotFound();
            }

            _context.SavingGoals.Remove(savingsGoal);
            await _context.SaveChangesAsync();

            return savingsGoal;
        }
        private bool GoalExists(int id)
        {
            return _context.SavingGoals.Any(e => e.ID == id);
        }
    }


}
