using AutoMapper;
using UdemyJwtApp.Back.Core.Application.Dto;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Core.Application.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            this.CreateMap<Category, CategoryListDto>().ReverseMap();
        }
    }
}
