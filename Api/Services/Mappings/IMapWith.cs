using AutoMapper;

namespace ShopOnline.API.Services.Helpers.Mappings
{
    public interface IMapWith<TEntity>
    {
        void Mapping(Profile profile) =>
            profile.CreateMap(typeof(TEntity), GetType());
    }
}
 