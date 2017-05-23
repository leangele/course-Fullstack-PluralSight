using System.Collections.Generic;
using System.Linq;
using FullStack.net.PluralSight.Core.Models;

namespace FullStack.net.PluralSight.Core.ViewModel
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool ShowActions { get; set; }
        public string Heading { get; set; }
        public string SearchTerm { get; set; }
        public ILookup<int, Attendance> Attendance { get; set; }
    }
}