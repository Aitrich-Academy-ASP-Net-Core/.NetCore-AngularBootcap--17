using Microsoft.AspNetCore.Mvc;
using Domain.Service;
using Domain.Interface;
using Domain.Model;
using Domain.Dto;

namespace WebApplication1API.Controllers
{
   
        [ApiController]
        [Route("api/[controller]")]
        public class JobsController : ControllerBase
        {
            private readonly IJobService _jobService;

            public JobsController(IJobService jobService)
            {
                _jobService = jobService;
            }

            [HttpGet("GetAllJobs")]
            public async Task<IActionResult> GetAllJobs()
            {
                var jobs = await _jobService.GetAllJobsAsync();
                return Ok(jobs);
            }
        // POST: api/jobs
        [HttpPost]
        public async Task<IActionResult> CreateJob([FromBody] JobCreateDto jobCreateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdJob = await _jobService.CreateJobAsync(jobCreateDto);

            // Returns 201 Created + Location header
            return CreatedAtAction(nameof(GetAllJobs), new { id = createdJob.Id }, createdJob);
        }


        // PUT: api/jobs/UpdateJob/5
        [HttpPut("UpdateJob/{id}")]
        public async Task<IActionResult> UpdateJob(int id, [FromBody] JobDto jobDto)
        {
            if (id != jobDto.Id)
                return BadRequest("Job ID mismatch");

            var updatedJob = await _jobService.UpdateJobAsync(jobDto);
            if (updatedJob == null)
                return NotFound();

            return Ok(updatedJob);
        }

        // DELETE: api/jobs/DeleteJob/5
        [HttpDelete("DeleteJob/{id}")]
        public async Task<IActionResult> DeleteJob(int id)
        {
            var result = await _jobService.DeleteJobAsync(id);
            if (!result)
                return NotFound();

            return NoContent();
        }
    }
    
}

