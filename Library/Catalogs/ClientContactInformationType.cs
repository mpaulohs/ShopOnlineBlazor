﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnlinePWA.Library.Catalogs
{
    public class ClientContactInformationType
    {
        public Guid Id { get; set; }

        public int ExchangeId { get; set; }

        public string Name { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}