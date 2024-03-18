using MyGoals.Services.Interfaces;
using MyGoals.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyGoals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoalController : Controller
    {
        private readonly IGoalService _goalService;

        public GoalController(IGoalService goalService)
        {
            _goalService = goalService;
        }

        // GET: api/Goal
        [Route("all")]
        [HttpGet]
        public async Task<IActionResult> GetGoalsAsync()
        {
            var goals = await _goalService.GetAllGoalsAsync();

            return Ok(goals);
        }

        // GET: api/Goal/5
        [HttpGet("{code}")]
        public async Task<IActionResult> GetGoalAsync(int code)
        {
            var goal = await _goalService.GetGoalByCodeAsync(code);

            if (goal == null)
            {
                return NotFound();
            }

            return Ok(goal);
        }

        // POST: api/Goal
        [HttpPost]
        public async Task<IActionResult> PostGoalAsync(Goal goal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdGoal = await _goalService.CreateGoalAsync(goal);

            return CreatedAtAction(nameof(GetGoalAsync), new { code = createdGoal.Code }, createdGoal);
        }

        // PUT: api/Goal/5
        [HttpPut("{code}")]
        public async Task<IActionResult> PutGoalAsync(int code, [FromBody] Goal goal)
        {
            if (code != goal.Code)
            {
                return BadRequest();
            }

            var updatedGoal = await _goalService.UpdateGoalAsync(goal);

            return Ok(updatedGoal);
        }

        // DELETE: api/Goal/5
        [HttpDelete("{code}")]
        public async Task<IActionResult> DeleteGoalAsync(int code)
        {
            var goal = await _goalService.GetGoalByCodeAsync(code);

            if (goal == null)
            {
                return NotFound();
            }

            await _goalService.DeleteGoalAsync(code);

            return NoContent();
        }
    }
}

