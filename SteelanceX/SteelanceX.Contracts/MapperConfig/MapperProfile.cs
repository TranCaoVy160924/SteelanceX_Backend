using AutoMapper;
using SteelanceX.Contracts.FreelancerProfile.Response;
using SteelanceX.Contracts.Job.Response;

namespace SteelanceX.Contracts.MapperConfig;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        #region Job
        CreateMap<Domain.Models.Job, JobResponse>()
            .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.Categories.Select(c => c.CategoryId)))
            .ForMember(dest => dest.BusinessName, opt => opt.MapFrom(src => src.BusinessProfile.BusinessName));
        #endregion

        #region Freelancer
        CreateMap<Domain.Models.FreelancerProfile, FreelancerResponse>()
            .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.Categories.Select(f => f.CategoryId)))
            .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => src.AppUser.Lastname + src.AppUser.Firstname))
            .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.AppUser.Address));
        #endregion
    }
}
