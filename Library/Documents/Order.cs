﻿using ShopOnlinePWA.Library.Catalogs;
using ShopOnlinePWA.Library.Identity;
using System;
using System.ComponentModel.DataAnnotations;


namespace ShopOnlinePWA.Library.Documents
{
    public class Order
    {
        public Guid Id { get; set; }

        public int ExchangeId { get; set; }

        public DateTime Date { get; set; }

        public User Owner { get; set; }

        public ClientContactInformation ContactInformation { get; set; }

        public User Client { get; set; }

        public DocumentStatus Status { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

    }
}