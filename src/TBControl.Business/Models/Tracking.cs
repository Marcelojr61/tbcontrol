using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class Tracking : Entity
    {
        Tracking()
        {
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public string TrackCode { get; set; }

        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }

    }
}
