using System.Collections.Generic;
using System.Linq;
using FullStack.net.PluralSight.Core.Models;
using FullStack.net.PluralSight.Core.Repositories;

namespace FullStack.net.PluralSight.Persistence.Repositories
{
    public class GenreReporsitory : IGenreReporsitory
    {
        private readonly ApplicationDbContext _context;


        public GenreReporsitory(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Genre> GetGenres()
        {
            return _context.Genres.ToList();
        }
    }
}