using AutoMapper;

namespace ShopOnlinePWA.Library.Helpers.Mappings
{
    public interface IMapWith<TEntity>
    {
        void Mapping(Profile profile) =>
            profile.CreateMap(typeof(TEntity), GetType());
    }
}
 