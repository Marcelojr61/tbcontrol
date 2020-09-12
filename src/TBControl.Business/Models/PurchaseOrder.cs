using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Subtotal { get; set; }
        public double DeliveryFee { get; set; }
        public double OrderTotal { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public Guid ProviderId { get; set; }
        public Provider Provider { get; set; }

        public Guid TrackingId { get; set; }
        public Tracking Tracking { get; set; }
    }
}
