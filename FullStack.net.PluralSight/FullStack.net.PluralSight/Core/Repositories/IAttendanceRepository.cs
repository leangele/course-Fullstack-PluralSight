using System.Collections.Generic;
using FullStack.net.PluralSight.Core.Models;

namespace FullStack.net.PluralSight.Core.Repositories
{
    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> GetFutureAttendances(string userId);
        bool GetAttendaceByid(int id, string userId);
    }
}