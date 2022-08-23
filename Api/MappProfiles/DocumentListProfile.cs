using System;
using AutoMapper;
using Shared.Models.Catalogs;
using Shared.Models.Documents;
using Shared.Models.Dtos;

namespace Api.MappProfiles;

public class DocumentListProfile : Profile
{
    public DocumentListProfile()
    {
        CreateMap<DocumentSale<Guid>, DocumentsListDTO<Guid>>()
        .ForMember(dest => dest.Number, sorce => sorce.MapFrom(p => p.ExchangeId))
        .ForMember(dest => dest.DocumentType, sorce => sorce.MapFrom(p => p.DocumentType.Name))
        .ForMember(dest => dest.DocumentStatus, sorce => sorce.MapFrom(p => p.DocumentStatus.Name))
        .ForMember(dest => dest.Client, sorce => sorce.MapFrom(p => p.Client.UserName))
        .ForMember(dest => dest.DocumentCurrency, sorce => sorce.MapFrom(p => p.DocumentCurrency.Name));

        CreateProjection<DocumentSale<Guid>, DocumentsListDTO<Guid>>()
        .ForMember(dest => dest.Number, sorce => sorce.MapFrom(p => p.ExchangeId))
        .ForMember(dest => dest.DocumentType, sorce => sorce.MapFrom(p => p.DocumentType.Name))
        .ForMember(dest => dest.DocumentStatus, sorce => sorce.MapFrom(p => p.DocumentStatus.Name))
        .ForMember(dest => dest.Client, sorce => sorce.MapFrom(p => p.Client.UserName))
        .ForMember(dest => dest.DocumentCurrency, sorce => sorce.MapFrom(p => p.DocumentCurrency.Name));
    }
}
