using AutoMapper;
using DotNetCore_Angular_SocialMedia_App.DTOs;
using DotNetCore_Angular_SocialMedia_App.Entities;
using DotNetCore_Angular_SocialMedia_App.Extensions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DotNetCore_Angular_SocialMedia_App.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
                .ForMember(d => d.Age, o => o.MapFrom(s => s.DateOfBirth.CalculateAge()))
                .ForMember(d => d.PhotoUrl, o =>
                    o.MapFrom(s => s.Photos.FirstOrDefault(x => x.IsMain)!.Url));
            CreateMap<Photo, PhotoDto>();
        }
    }
}
