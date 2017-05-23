using AutoMapper;
using FullStack.net.PluralSight.Core.Dtos;
using FullStack.net.PluralSight.Core.Models;

namespace FullStack.net.PluralSight.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserDto>();
            CreateMap<Gig, GigDto>();
            CreateMap<Genre, GenreDto>();
            CreateMap<Notification, NotificationDto>();
        }
    }
}