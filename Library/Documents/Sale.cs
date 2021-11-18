﻿using System;
using System.ComponentModel.DataAnnotations;
using ShopOnlinePWA.Library.Repositories;

namespace ShopOnlinePWA.Library.Documents 
{
    public class Sale : IEntityBase<Guid>
    {
        public Guid Id { get; set; }

        public int ExchangeId { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
