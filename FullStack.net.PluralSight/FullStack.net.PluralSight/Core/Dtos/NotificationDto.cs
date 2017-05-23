using System;
using FullStack.net.PluralSight.Core.Models;

namespace FullStack.net.PluralSight.Core.Dtos
{
    public class NotificationDto
    {
        public DateTime Datetime { get; set; }
        public NotificationType Type { get; set; }
        public DateTime? OriginalDateTime { get; set; }
        public string OriginalVenue { get; set; }
        public GigDto Gig { get; set; }

    }
}