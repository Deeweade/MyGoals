using MyGoals.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MyGoals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IHomeService _service;

        public HomeController(IHomeService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("FillConstants")]
        public async Task<IActionResult> FillDbConstants()
        {
            await _service.FillDbConstants();
            return Ok();
        }

        [HttpPost]
        [Route("FillCurrentYearPeiods")]
        public async Task<IActionResult> FillCurrentYearPeriods()
        {
            await _service.FillCurrentYearPeriods();
            return Ok();
        }
    }
}

