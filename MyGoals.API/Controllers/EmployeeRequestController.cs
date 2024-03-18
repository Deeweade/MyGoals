using MyGoals.Services.Interfaces;
using MyGoals.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyGoals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeRequestController : ControllerBase
    {
        private readonly IEmployeeRequestService _employeeRequestService;

        public EmployeeRequestController(IEmployeeRequestService employeeRequestService)
        {
            _employeeRequestService = employeeRequestService;
        }

        [Route("all")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeRequest>>> GetEmployeeRequestsAsync()
        {
            var employeeRequests = await _employeeRequestService.GetAllEmployeeRequestsAsync();

            return Ok(employeeRequests);
        }

        [HttpGet("{code}")]
        public async Task<ActionResult<EmployeeRequest>> GetEmployeeRequestAsync(int code)
        {
            var employeeRequest = await _employeeRequestService.GetActiveByCodeAsync(code);

            if (employeeRequest == null)
            {
                return NotFound();
            }

            return Ok(employeeRequest);
        }
        
        [HttpPost]
        public async Task<ActionResult<EmployeeRequest>> PostEmployeeRequestAsync(EmployeeRequest employeeRequest)
        {
            var createdEmployeeRequest = await _employeeRequestService.CreateEmployeeRequest(employeeRequest);

            return CreatedAtAction(nameof(GetEmployeeRequestAsync), new { code = createdEmployeeRequest.Code }, createdEmployeeRequest);
        }

        [HttpPut("{code}")]
        public async Task<IActionResult> PutEmployeeRequestAsync(int code, EmployeeRequest employeeRequest)
        {
            if (code != employeeRequest.Code)
            {
                return BadRequest();
            }

            var updatedEmployeeRequest = await _employeeRequestService.UpdateEmployeeRequest(employeeRequest);

            return Ok(updatedEmployeeRequest);
        }

        [HttpDelete("{code}")]
        public async Task<IActionResult> DeleteEmployeeRequestAsync(int code)
        {
            var employeeRequest = await _employeeRequestService.GetActiveByCodeAsync(code);

            if (employeeRequest == null)
            {
                return NotFound();
            }

            await _employeeRequestService.DeleteEmployeeRequestAsync(code);

            return NoContent();
        }
    }
}

