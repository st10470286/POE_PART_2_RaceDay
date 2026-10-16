using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RaceDay.API.Data;
using RaceDay.API.Models;

namespace RaceDay.API.Controllers
{
    [Route("api/enrolments")]
    [ApiController]
    public class EnrolmentsController : ControllerBase
    {
        private readonly RaceDayDbContext _context;

        public EnrolmentsController(RaceDayDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Enrol([FromBody] EventEnrolment enrolment)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
            {
                return Unauthorized(new { message = "You must be logged in to enrol." });
            }

            enrolment.ParticipantId = userId.Value;
            enrolment.EnrolmentDate = DateTime.Now;

            _context.EventEnrolments.Add(enrolment);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                return BadRequest(new { message = "You are already enrolled in this category." });
            }

            return StatusCode(201, new { message = "Successfully enrolled in event category!" });
        }
    }
}