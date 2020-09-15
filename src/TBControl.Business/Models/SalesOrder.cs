using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class SalesOrder : Entity
    {
        public int Quantity { get; set; }
        public double Subtotal { get; set; }
        public double DeliveryFee { get; set; }
        public double Rebate { get; set; }
        public double OrderTotal { get; set; }

        public Guid ClientId { get; set; }
        public Client Client { get; set; }

        public Guid OrderedItemId { get; set; }
        public OrderedItem OrderedItem { get; set; }

        public Guid FormOfPaymentId { get; set; }
        public FormOfPayment FormOfPayment { get; set; }
    }
}
