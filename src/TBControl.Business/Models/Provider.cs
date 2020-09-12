﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class Provider : Entity
    {
        public string ProviderName { get; set; }
        public string Document { get; set; }
        public bool Active { get; set; }

        public Guid AddressProviderId { get; set; }
        public AddressProvider AddressProvider { get; set; }
    }
}
