using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnlinePWA.Library.Catalogs
{
    public class AdditionalInformation
    {
        public Guid Id { get; set; }

        public int ExchangeId { get; set; }

        public AdditionalInformationType Type { get; set; }

        public string Value { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

        
    }

}
