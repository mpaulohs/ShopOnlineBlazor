namespace ShopOnlinePWA.Library.Repositories
{
    public interface IEntityBase<TId>
    {
        public TId Id { get; set; }
    }
}
