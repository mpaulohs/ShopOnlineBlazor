using ShopOnline.Shared.Models.Catalogs;
using ShopOnline.Shared.Models.Identities;
using System.ComponentModel.DataAnnotations;

namespace ShopOnline.Shared.Models.Documents
{
    public class DocumentSale<TKey> : DocumentBase<TKey>
        where TKey : IEquatable<TKey>
    {
        public Storage<TKey>? Storage { get; set; }

        public User<TKey>? Reciver { get; set; }

        [MaxLength(255)]
        public string? ReciverAddres { get; set; }

        [MaxLength(20)]
        public string? ReciverPhoneNumber { get; set; }

        public DocumentStatus DocumentStatus { get; set; }

    }
}
