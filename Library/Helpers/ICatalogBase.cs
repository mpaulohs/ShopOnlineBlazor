namespace ShopOnlinePWA.Library
{
    public interface ICatalogBase<TKey> : IEntityBase<TKey>
    {
        public string Name { get; set; }
        public string Comment { get; set; }

    }
}
