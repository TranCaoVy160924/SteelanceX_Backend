using AutoMapper;
using BusinessObject.Models;
using DataTransferObject.Category;
using DataTransferObject.Customer;
using DataTransferObject.FlowerBouquet;
using DataTransferObject.Supplier;

namespace Application.MapperConfig;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        #region FlowerBouquet
        CreateMap<FlowerBouquet, FlowerBouquetResponse>()
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
            .ForMember(dest => dest.SupplierName, opt => opt.MapFrom(src => src.Supplier.SupplierName))
            .ForMember(dest => dest.FlowerBouquetStatus, opt => opt.MapFrom(src => src.FlowerBouquetStatus == 1));

        CreateMap<FlowerBouquetCreateRequest, FlowerBouquet>()
            .ForMember(dest => dest.FlowerBouquetStatus, opt => opt.MapFrom(src => true));

        CreateMap<FlowerBouquetResponse, FlowerBouquetUpdateRequest>();
        #endregion

        #region Category
        CreateMap<Category, CategorySelectItem>();
        #endregion

        #region Supplier
        CreateMap<Supplier, SupplierSelectItem>();
        #endregion

        #region Customer
        CreateMap<Customer, CustomerResponse>();
        CreateMap<RegisterRequest, Customer>();
        #endregion
    }
}
