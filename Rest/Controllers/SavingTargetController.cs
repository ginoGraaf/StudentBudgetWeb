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
    [Route("api/SavingTarget")]
    [ApiController]
    public class SavingTargetController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public SavingTargetController(ApplicationContext context)
        {

            this._context = context;
        }
        // GET: api/SavingTarget/5
        [HttpGet]
        [Route("{Id}")]
        public async Task<ActionResult<SavingGoalsModel>> Get(int ID)
        {
            SavingGoalsModel savingsGoal = await _context.SavingGoals.FindAsync(ID);
            if (savingsGoal == null)
            {
                return NotFound();
            }
            return savingsGoal;
        }

        // POST: api/SavingTarget
        [HttpPost]
        public async Task<ActionResult<SavingGoalsModel>> Post([FromBody] SavingGoalsModel savingTarget)
        {

            _context.SavingGoals.Add(savingTarget);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetSavingTarget", new { id = savingTarget.ID }, savingTarget);
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
