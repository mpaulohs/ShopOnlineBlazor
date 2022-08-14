using Shared.Models.Catalogs;
using System.ComponentModel.DataAnnotations.Schema;
namespace Shared.Models.Registers
{
    public class CurencyCalendar<TKey>
      where TKey : IEquatable<TKey>
    {
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public Currency<TKey>? Currency { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Multiplisity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CurencyValue { get; set; }
    }
}
