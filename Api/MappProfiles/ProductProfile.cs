using System;
using AutoMapper;
using Shared.Models.Catalogs;
using Shared.Models.Dtos;

namespace Api.MappProfiles
{
    class ProductProfile : Profile
    {
        public ProductProfile()
        {
            new MapperConfiguration(conf =>
            {

                conf.CreateProjection<Product<Guid>, ProductDTO<Guid>>().ForMember(dest => dest.ProductSerie, act => act.MapFrom(source => source.ProductSerie.Name));
                // .ForMember(destinationMember => destinationMember.ProductQuality, memberOptions => memberOptions.MapFrom(src => src.ProductQuality.Name));
            });
        }
    }
}