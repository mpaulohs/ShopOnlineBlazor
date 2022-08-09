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
                conf.CreateProjection<Product<Guid>, ProductDTO<Guid>>();
                // .ForMember(destinationMember => destinationMember.ProductQuality, memberOptions => memberOptions.MapFrom(src => src.ProductQuality.Name));
            });
        }
    }
}