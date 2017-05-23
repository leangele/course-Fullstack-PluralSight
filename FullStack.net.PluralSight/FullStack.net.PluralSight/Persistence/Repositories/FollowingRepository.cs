using System.Collections.Generic;
using System.Linq;
using FullStack.net.PluralSight.Core.Models;
using FullStack.net.PluralSight.Core.Repositories;

namespace FullStack.net.PluralSight.Persistence.Repositories
{
    public class FollowingRepository : IFollowingRepository
    {
        private readonly ApplicationDbContext _context;

        public FollowingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool GetMyFollowings(string id, string userId)
        {
            return _context.Followings.Any(a => a.FolloweeId == id && a.FollowerId == userId);
        }

        public IEnumerable<ApplicationUser> GetFollowingsList(string userId)
        {
            return _context.Followings
                .Where(f => f.FollowerId == userId)
                .Select(f => f.Followee)
                .ToList();
        }
    }
}