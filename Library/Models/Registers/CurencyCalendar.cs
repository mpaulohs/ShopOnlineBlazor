using ShopOnline.Library.Models.Catalogs;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Library.Models.Registers
{
    public class CurencyCalendar
    {
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public Currency? Currency { get; set; }

        public decimal Multiplisity { get; set; }

        public decimal CurencyValue { get; set; }
    }
}
