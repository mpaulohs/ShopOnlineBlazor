using System;

namespace ShopOnlinePWA.Library
{
    public class DocumentSale : DocumentBase<Guid>, IDocumentSale
    {
        public Storage Storage { get; set; }

        public User Reciver { get; set; }

        public string ReciverAddres { get; set; }

        public string ReciverPhoneNumber { get; set; }

        public DocumentStatus DocumentStatus { get; set; }

    }
}
