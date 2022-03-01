using SharedLib.Models.Catalogs;
using SharedLib.Models.Identities;
using System.ComponentModel.DataAnnotations;

namespace SharedLib.Models.Documents
{
    public class DocumentSale : DocumentBase<Guid>
    {
        public Storage? Storage { get; set; }

        public User? Reciver { get; set; }

        [MaxLength(255)]
        public string? ReciverAddres { get; set; }

        [MaxLength(20)]
        public string? ReciverPhoneNumber { get; set; }

        public DocumentStatus DocumentStatus { get; set; }

    }
}
