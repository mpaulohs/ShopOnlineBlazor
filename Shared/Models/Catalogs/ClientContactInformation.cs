﻿using ShopOnline.Shared.Models.Identities;
using System.ComponentModel.DataAnnotations;

namespace ShopOnline.Shared.Models.Catalogs
{
    public class ClientContactInformation : CatalogBase<Guid>
    { 
        public User? Client { get; set; }

        public ClientContactInformationType? ClientContactInformationType { get; set; }

        [MaxLength(255)]
        public string? Value { get; set; }


    }
}
