using AutoMapper;
using Onion.JwtApp.Application.Dto;
using Onion.JwtApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JwtApp.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            this.CreateMap<Product, ProductListDto>().ReverseMap();
            this.CreateMap<Product,CreatedProductDto>().ReverseMap();
        }
    }
}
