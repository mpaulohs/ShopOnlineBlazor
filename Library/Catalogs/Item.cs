using ShopOnlinePWA.Library.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopOnlinePWA.Library.Catalogs
{
    public class Item : IEntityBase<Guid>
    {
        public Guid Id { get; set; }

        public int ExchangeId { get; set; }

        public string Article { get; set; }

        public string Name { get; set; }

        [Display(Name = "Full name")]
        public string FullName { get; set; }

        public ItemType ItemType { get; set; }

        public ItemCharacteristic ItemCharacteristic { get; set; }

        public ItemQuality ItemQuality { get; set; }

        public ItemSerie ItemSerie { get; set; }

        public ItemUnitMeasurement itemUnitMeasurement { get; set; }

        public string Description { get; set; }

        public ICollection<AdditionalInformation> AdditionalInformations { get; set; }

        public int Price { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
