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
<<<<<<< HEAD
            CreateMap<Product<Guid>, ProductDTO<Guid>>()
            .ForMember(dest => dest.ProductType, sorce => sorce.MapFrom(p => p.ProductType.Name))
            .ForMember(dest => dest.ProductQuality, sorce => sorce.MapFrom(p => p.ProductQuality.Name))
            .ForMember(dest => dest.ProductSerie, sorce => sorce.MapFrom(p => p.ProductSerie.Name))
            .ForMember(dest => dest.ProductUnitMeasurement, sorce => sorce.MapFrom(p => p.ProductUnitMeasurement.Name));

            CreateProjection<Product<Guid>, ProductDTO<Guid>>()
            .ForMember(dest => dest.ProductType, sorce => sorce.MapFrom(p => p.ProductType.Name))
            .ForMember(dest => dest.ProductQuality, sorce => sorce.MapFrom(p => p.ProductQuality.Name))
            .ForMember(dest => dest.ProductSerie, sorce => sorce.MapFrom(p => p.ProductSerie.Name))
            .ForMember(dest => dest.ProductUnitMeasurement, sorce => sorce.MapFrom(p => p.ProductUnitMeasurement.Name));
=======
            CreateMap<Product<Guid>, ProductDTO<Guid>>();
            CreateProjection<Product<Guid>, ProductDTO<Guid>>();
>>>>>>> 0e71f15f1900dcf0c5828fbf033dd69041ad61ed
        }
    }
}