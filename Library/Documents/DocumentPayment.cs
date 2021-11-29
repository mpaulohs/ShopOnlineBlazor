using ShopOnlinePWA.Library.Catalogs;
using ShopOnlinePWA.Library.Repositories;
using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnlinePWA.Library.Documents
{
    public class DocumentPayment : DocumentBase<Guid>, IDocumentPayment
    {
        public Currency Currency { get; set; }
    }
}
