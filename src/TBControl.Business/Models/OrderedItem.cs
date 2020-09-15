using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class OrderedItem : Entity
    {
        public OrderedItem()
        {
            this.Products = new HashSet<Product>();
        }

        public SalesOrder SalesOrder { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
