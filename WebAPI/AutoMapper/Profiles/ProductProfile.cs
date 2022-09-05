using AutoMapper;
using Entities.Modals;
using Entities.Modals.Dto;

namespace WebAPI.AutoMapper.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductDto, Product>().ReverseMap();
        }
    }
}
