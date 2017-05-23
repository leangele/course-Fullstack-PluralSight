using System;
using System.Collections.Generic;
using System.Linq;
using FullStack.net.PluralSight.Core.Models;
using FullStack.net.PluralSight.Core.Repositories;

namespace FullStack.net.PluralSight.Persistence.Repositories
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly ApplicationDbContext _context;

        public AttendanceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Attendance> GetFutureAttendances(string userId)
        {
            return _context.Attendances
                .Where(a => a.AttendeeId == userId && a.Gig.DateTime > DateTime.Now)
                .ToList();
        }

        public bool GetAttendaceByid(int id, string userId)
        {
            return _context
                .Attendances.Any(a => a.GigId == id && a.AttendeeId == userId);
        }


    }
}