using System;

namespace ShopOnline.Library
{
    public class DocumentSale : DocumentBase<Guid>
    {
        public Storage Storage { get; set; }

        public User Reciver { get; set; }

        public string ReciverAddres { get; set; }

        public string ReciverPhoneNumber { get; set; }

        public DocumentStatus DocumentStatus { get; set; }

    }
}
