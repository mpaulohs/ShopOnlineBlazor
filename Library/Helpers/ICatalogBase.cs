namespace ShopOnlinePWA.Library
{
    public interface ICatalogBase<TId> : IEntityBase<TId>
    {
        public string Name { get; set; }

        public string Comment { get; set; }

    }
}
