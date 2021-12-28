using ShopOnline.Library.Models.Catalogs;
using ShopOnline.Library.Services;
using System;

namespace ShopOnline.Library.Models.Documents
{
    public class DocumentPayment : DocumentBase<Guid>
    {
        public Currency Currency { get; set; }


        //ToDo
        //public IDocumentPaymentRessiver PaymentRessiver { get; set; }
    }
}
