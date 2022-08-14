using System;
using AutoMapper;
using Shared.Models.Catalogs;
using Shared.Models.Dtos;
namespace Api.MappProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product<Guid>, ProductDTO<Guid>>();
            CreateProjection<Product<Guid>, ProductDTO<Guid>>();
        }
    }
}