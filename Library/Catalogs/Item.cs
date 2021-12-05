using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnlinePWA.Library
{
    public class Item : CatalogBase<Guid>
    {
        public string Article { get; set; }

        [Display(Name = "Full name")]
        public string FullName { get; set; }

        public ItemType ItemType { get; set; }

        public ItemCharacteristic ItemCharacteristic { get; set; }

        public ItemQuality ItemQuality { get; set; }

        public ItemSerie ItemSerie { get; set; }

        public ItemUnitMeasurement itemUnitMeasurement { get; set; }

        public string Description { get; set; }

    }
}
