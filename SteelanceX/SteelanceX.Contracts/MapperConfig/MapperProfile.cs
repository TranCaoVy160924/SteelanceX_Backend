using AutoMapper;
using SteelanceX.Contracts.Job.Response;
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
        #endregion

        //#region Customer
        //CreateMap<Customer, CustomerResponse>();
        //CreateMap<RegisterRequest, Customer>();
        //#endregion
    }
}
