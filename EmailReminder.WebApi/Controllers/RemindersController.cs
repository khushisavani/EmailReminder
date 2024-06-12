using System;
using System.Linq;
using System.Threading.Tasks;
using EmailReminder.Shared.Models;
using EmailReminder.WebApi.Data;
using EmailReminder.WebApi.Services;
using Hangfire;
using Microsoft.AspNetCore.Mvc;

namespace EmailReminder.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RemindersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IBackgroundJobClient _backgroundJobClient;

        public RemindersController(
            ApplicationDbContext context,
            IBackgroundJobClient backgroundJobClient)
        {
            _context = context;
            _backgroundJobClient = backgroundJobClient;
        }


        [HttpPost]
        public async Task<IActionResult> CreateReminder([FromBody]Reminder reminder)
        {
            try
            {
                _context.Reminders.Add(reminder);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                return BadRequest("Could not save reminder.");
            }

            _backgroundJobClient.Schedule<IMailSender>(x => x.SendReminder(reminder), new DateTimeOffset(reminder.DateTime));
            return Ok(reminder);
        }
    }
}