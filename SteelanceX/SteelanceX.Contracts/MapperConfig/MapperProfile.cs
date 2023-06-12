using AutoMapper;
using SteelanceX.Contracts.DataTransferObjects.FreelancerProfile.Response;
using SteelanceX.Contracts.DataTransferObjects.Job.Request;
using SteelanceX.Contracts.DataTransferObjects.Job.Response;
using SteelanceX.Domain.Models;

namespace SteelanceX.Contracts.MapperConfig;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        #region Job
        CreateMap<Domain.Models.Job, JobResponse>()
            .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.Categories.Select(c => c.CategoryId)))
            .ForMember(dest => dest.BusinessName, opt => opt.MapFrom(src => src.BusinessProfile.BusinessName));
        CreateMap<JobResponse, Domain.Models.Job>()
            .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => true))
            .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now))
            .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => new List<JobCategory>()))
            .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => Convert.ToDateTime(src.ApplyExpireDate)));
        #endregion

        #region Freelancer
        CreateMap<Domain.Models.FreelancerProfile, FreelancerResponse>()
            .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.Categories.Select(f => f.CategoryId)))
            .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => src.AppUser.Lastname + src.AppUser.Firstname))
            .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.AppUser.Address));
        CreateMap<FreelancerResponse, Domain.Models.FreelancerProfile>()
            .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.Categories.ToList()));
        #endregion
    }
}
