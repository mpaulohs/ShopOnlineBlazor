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
        }
    }
}