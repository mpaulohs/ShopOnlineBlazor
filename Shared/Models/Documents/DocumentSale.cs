using Shared.Models.Catalogs;
using Shared.Models.Identities;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Documents
{
    public class DocumentSale<TKey> : DocumentBase<TKey>
    {
        public Storage<TKey>? Storage { get; set; }

        public User? Reciver { get; set; }

        [MaxLength(255)]
        public string? ReciverAddres { get; set; }

        [MaxLength(20)]
        public string? ReciverPhoneNumber { get; set; }

        public DocumentStatus<TKey> DocumentStatus { get; set; }

    }
}
