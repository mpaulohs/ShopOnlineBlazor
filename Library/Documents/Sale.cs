using ShopOnlinePWA.Library.Catalogs;
using ShopOnlinePWA.Library.Identity;
using ShopOnlinePWA.Library.Repositories;
using System;

namespace ShopOnlinePWA.Library.Documents
{
    public class Sale : DocumentBase<Guid>
    {
        public Storage? Storage { get; set; }

        public User? Reciver { get; set; }

        public string? ReciverAddres { get; set; }

        public string? ReciverPhoneNumber { get; set; }

        public DocumentStatus? documentStatus { get; set; }

    }
}
