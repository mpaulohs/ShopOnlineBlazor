using Shared.Models.Catalogs;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models.Registers
{
    public class CurencyCalendar<Tkey>
    {
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public Currency<Tkey>? Currency { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Multiplisity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CurencyValue { get; set; }
    }
}
