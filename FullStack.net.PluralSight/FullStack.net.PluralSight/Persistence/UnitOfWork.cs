using FullStack.net.PluralSight.Core;
using FullStack.net.PluralSight.Core.Models;
using FullStack.net.PluralSight.Core.Repositories;
using FullStack.net.PluralSight.Persistence.Repositories;

namespace FullStack.net.PluralSight.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IGigRepository Gigs { get; private set; }
        public IAttendanceRepository Attendances { get; private set; }
        public IGenreReporsitory Genres { get; set; }
        public IFollowingRepository Followings { get; set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Gigs = new GigRepository(_context);
            Attendances = new AttendanceRepository(_context);
            Genres = new GenreReporsitory(_context);
            Followings = new FollowingRepository(_context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}