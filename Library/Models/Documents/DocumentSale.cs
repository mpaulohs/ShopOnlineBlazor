using ShopOnline.Library.Models.Catalogs;
using ShopOnline.Library.Models.Identities;
using ShopOnline.Library.Services;
using System;

namespace ShopOnline.Library.Models.Documents
{
    public class DocumentSale : DocumentBase<Guid>
    {
        public Storage? Storage { get; set; }

        public User? Reciver { get; set; }

        public string? ReciverAddres { get; set; }

        public string? ReciverPhoneNumber { get; set; }

        public DocumentStatus DocumentStatus { get; set; }

    }
}
