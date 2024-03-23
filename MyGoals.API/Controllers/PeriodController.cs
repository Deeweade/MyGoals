using MyGoals.Services.Interfaces;
using MyGoals.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyGoals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodController : ControllerBase
    {
        private readonly IPeriodService _periodService;

        public PeriodController(IPeriodService periodService)
        {
            _periodService = periodService;
        }

        // GET: api/Period
        [HttpGet]
        public async Task<IActionResult> GetPeriods()
        {
            var periods = await _periodService.GetAllPeriodsAsync();
            return Ok(periods);
        }

        // GET: api/Period/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPeriod(int id)
        {
            var period = await _periodService.GetPeriodByIdAsync(id);
            if (period == null)
            {
                return NotFound();
            }
            return Ok(period);
        }

        // POST: api/Period
        [HttpPost]
        public async Task<IActionResult> PostPeriod([FromBody] Period period)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createdPeriod = await _periodService.CreatePeriodAsync(period);
            return CreatedAtAction(nameof(GetPeriod), new { id = createdPeriod.Id }, createdPeriod);
        }

        // PUT: api/Period/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeriod(int id, [FromBody] Period period)
        {
            if (id != period.Id)
            {
                return BadRequest();
            }
            var updatedPeriod = await _periodService.UpdatePeriodAsync(period);
            return Ok(updatedPeriod);
        }

        // DELETE: api/Period/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePeriod(int id)
        {
            var period = await _periodService.GetPeriodByIdAsync(id);
            if (period == null)
            {
                return NotFound();
            }
            await _periodService.DeletePeriodAsync(id);
            return NoContent();
        }
    }
}

