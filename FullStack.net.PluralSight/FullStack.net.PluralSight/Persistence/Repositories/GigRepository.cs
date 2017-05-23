using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FullStack.net.PluralSight.Core.Models;
using FullStack.net.PluralSight.Core.Repositories;

namespace FullStack.net.PluralSight.Persistence.Repositories
{
    public class GigRepository : IGigRepository
    {
        private readonly ApplicationDbContext _context;

        public GigRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Gig GetGigWithAttendees(int gigId)
        {
            return _context.Gigs
               .Include(x => Enumerable.Select<Attendance, ApplicationUser>(x.Attendances, a => a.Attendee))
               .SingleOrDefault(x => x.Id == gigId);
        }

        public IEnumerable<Gig> GetGigsUserAttending(string userId)
        {
            return _context.Attendances
                .Where(x => x.AttendeeId == userId)
                .Select(x => x.Gig)
                .Include(y => y.Artist)
                .Include(y => y.Genre)
                .ToList();
        }

        public IEnumerable<Gig> GetMyGigs(string userId)
        {
            return _context.Gigs
                .Where(x =>
                    x.ArtistId == userId &&
                    x.DateTime > DateTime.Now &&
                    !x.IsCanceled)
                .Include(x => x.Genre)
                .ToList();
        }

        public Gig GetGig(int id)
        {
            return _context.Gigs
                .Include(g => g.Artist)
                .Include(g => g.Genre)
                .SingleOrDefault(g => g.Id == id);
        }

        public IQueryable<Gig> UpcomingGigs()
        {
            return _context.Gigs
                .Include(g => g.Artist)
                .Include(g => g.Genre)
                .Where(g => g.DateTime > DateTime.Now && !g.IsCanceled);
        }

        public void Add(Gig gig)
        {
            _context.Gigs.Add(gig);
        }
    }
}