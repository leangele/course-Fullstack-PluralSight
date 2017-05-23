using AutoMapper;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using FullStack.net.PluralSight.Core.Dtos;
using FullStack.net.PluralSight.Core.Models;
using FullStack.net.PluralSight.Persistence;

namespace FullStack.net.PluralSight.Controllers.Api
{
    [Authorize]
    public class NotificationsController : ApiController
    {
        private ApplicationDbContext _context;

        public NotificationsController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<NotificationDto> GetNewNotifications()
        {
            var userId = User.Identity.GetUserId();
            var notifications = _context.UserNotifications
                .Where(x => x.UserId == userId && !x.IsRead)
                .Select(un => un.Notification)
                .Include(n => n.Gig.Artist)
                .ToList();


            return notifications.Select(Mapper.Map<NotificationDto>);

        }

        [HttpPost]
        public IHttpActionResult MarkAsReaded()
        {
            var userId = User.Identity.GetUserId();
            var notifications = _context.UserNotifications.Where(x => x.UserId == userId && !x.IsRead).ToList();
            notifications.ForEach(n => n.Read());
            _context.SaveChanges();
            return Ok();
        }
    }
}
