using FullStack.net.PluralSight.Core.Repositories;

namespace FullStack.net.PluralSight.Core
{
    public interface IUnitOfWork
    {
        IGigRepository Gigs { get; }
        IAttendanceRepository Attendances { get; }
        IGenreReporsitory Genres { get; set; }
        IFollowingRepository Followings { get; set; }
        void Complete();
    }
}