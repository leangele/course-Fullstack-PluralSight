using System.Collections.Generic;
using System.Linq;
using FullStack.net.PluralSight.Core.Models;

namespace FullStack.net.PluralSight.Core.Repositories
{
    public interface IGigRepository
    {
        Gig GetGigWithAttendees(int gigId);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        IEnumerable<Gig> GetMyGigs(string userId);
        Gig GetGig(int id);
        void Add(Gig gig);
        IQueryable<Gig> UpcomingGigs();
    }
}