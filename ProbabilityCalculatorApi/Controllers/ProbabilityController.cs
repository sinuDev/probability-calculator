using Microsoft.AspNetCore.Mvc;
using ProbabilityCalculatorApi.Models;
using ProbabilityCalculatorApi.Services;

namespace ProbabilityCalculatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProbabilityController : ControllerBase
    {
        private readonly IProbabilityService _service;

        public ProbabilityController(IProbabilityService service)
        {
            _service = service;
        }

        [HttpPost("calculate")]
        public IActionResult Calculate([FromBody] ProbabilityRequest request)
        {
            try
            {
                var result = _service.Calculate(
                    request.ProbabilityA,
                    request.ProbabilityB,
                    request.CalculationType
                );

                return Ok(new ProbabilityResponse
                {
                    Result = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}