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
            new MapperConfiguration(cfg => cfg.CreateProjection<Product<Guid>, ProductDTO<Guid>>());
            // return await entities.ProjectTo<TOut>(configuration).ToListAsync<TOut>();
            // new MapperConfiguration(conf =>
            // {
            //     conf.CreateMap<Product<Guid>, ProductDTO<Guid>>().ReverseMap();
            //     conf.CreateProjection<Product<Guid>, ProductDTO<Guid>>()
            //     .ForMember(dest => dest.ProductSerie, act => act
            //     .MapFrom(source => source.ProductSerie.Name));
            //     // .ForMember(destinationMember => destinationMember.ProductQuality, memberOptions => memberOptions.MapFrom(src => src.ProductQuality.Name));
            // });
        }
    }
}