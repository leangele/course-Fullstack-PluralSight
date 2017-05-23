using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;
using FullStack.net.PluralSight.Core.Dtos;
using FullStack.net.PluralSight.Core.Models;
using FullStack.net.PluralSight.Persistence;

namespace FullStack.net.PluralSight.Controllers.Api
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto dto)
        {
            var userId = User.Identity.GetUserId();
            if (_context.Attendances.Any(x => x.AttendeeId == userId && x.GigId == dto.GigId))
            {
                return BadRequest("The attendance already exists.");
            }
            var attendance = new Attendance
            {
                GigId = dto.GigId,
                AttendeeId = User.Identity.GetUserId(),
            };
            _context.Attendances.Add(attendance);
            _context.SaveChanges();
            return Ok();

        }

        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var attendance = _context.Attendances
                .Single(g => g.AttendeeId == userId && g.GigId == id);

            if (attendance == null)
            {
                return NotFound();
            }

            _context.Attendances.Remove(attendance);
            _context.SaveChanges();
            return Ok();
        }
    }
}
