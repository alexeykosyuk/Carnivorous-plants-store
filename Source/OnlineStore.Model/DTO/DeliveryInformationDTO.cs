﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Model.DTO
{
    public class DeliveryInformationDTO
    {
        public string DeliveryInformationId { get; set; }

        public bool IsDefault { get; set; }

        public string Country { get; set; }

        public string Region { get; set; }

        public string Sity { get; set; }

        public string Street { get; set; }

        public string House { get; set; }

        public string Apartment { get; set; }

        public string CustomerId { get; set; }
    }
}
