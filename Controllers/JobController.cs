
using employer_jobs_api.Repository;
using masterdata_api.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace employer_jobs_api.Controllers
{
    [Route("api")]
    [ApiController]
    public class JobController  : ControllerBase
    {
        private readonly IJobRepository _jobRepo;

        public JobController(IJobRepository jobRepo)
        {
            _jobRepo = jobRepo;
        }
 

        [HttpGet("GetJobTitles")] // Get jobs Stats based on CustomerId and JobId 
        public async Task<IActionResult> GetJobTitle(string jobtitle)
        {
            try
            {


                var stats = await _jobRepo.GetJobTitles(jobtitle);
                if (stats == null)
                    return NotFound();

                return Ok(stats);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }




    }
}
