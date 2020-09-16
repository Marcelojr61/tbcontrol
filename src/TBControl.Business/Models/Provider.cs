using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class Provider : Entity
    {
        public Provider()
        {
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public string Name { get; set; }
        public string Document { get; set; }
        public bool Active { get; set; }

        public Guid AddressProviderId { get; set; }
        public AddressProvider AddressProvider { get; set; }

        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
