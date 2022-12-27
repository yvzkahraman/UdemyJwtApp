using AutoMapper;
using UdemyJwtApp.Back.Core.Application.Dto;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Core.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            this.CreateMap<Product, ProductListDto>().ReverseMap();
        }
    }
}
