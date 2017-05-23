using System.Collections.Generic;
using FullStack.net.PluralSight.Core.Models;

namespace FullStack.net.PluralSight.Core.Repositories
{
    public interface IFollowingRepository
    {
        bool GetMyFollowings(string id, string userId);
        IEnumerable<ApplicationUser> GetFollowingsList(string userId);
    }
}