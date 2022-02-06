using ShopOnline.Shared.Models.Catalogs;
using ShopOnline.Shared.Models.Identities;

namespace ShopOnline.Shared.Models.Documents
{
    public class DocumentSale : DocumentBase<Guid>
    {
        public virtual Storage? Storage { get; set; }

        public Guid StorageId { get; set; }

        public User? Reciver { get; set; }

        public string? ReciverAddres { get; set; }

        public string? ReciverPhoneNumber { get; set; }

        public DocumentStatus DocumentStatus { get; set; }

    }
}
