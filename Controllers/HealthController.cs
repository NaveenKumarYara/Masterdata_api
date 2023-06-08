using Microsoft.AspNetCore.Mvc;

namespace employer_jobs_api.Controllers
{
    [Route("api")]
    public class HealthController : ControllerBase
    {


        [HttpGet("health")]
        public IActionResult  Check()
        {
            // Add logic here to check dependencies
            var Value = "HI";
            return Ok(Value);


        }
    }
}
