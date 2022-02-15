﻿using ShopOnline.Shared.Models.Catalogs;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Shared.Models.Registers
{
    public class CurencyCalendar<TKey>
    {
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public Currency<TKey>? Currency { get; set; }

        [Column (TypeName = "decimal(18,2)")]
        public decimal Multiplisity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CurencyValue { get; set; }
    }
}
