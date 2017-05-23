using System.Collections.Generic;
using FullStack.net.PluralSight.Core.Models;

namespace FullStack.net.PluralSight.Core.Repositories
{
    public interface IGenreReporsitory
    {
        IEnumerable<Genre> GetGenres();
    }
}