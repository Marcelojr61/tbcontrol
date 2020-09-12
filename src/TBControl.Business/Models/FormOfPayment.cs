using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class FormOfPayment : Entity
    {
        FormOfPayment()
        {
            this.SalesOrders = new HashSet<SalesOrder>();
        }

        public string Type { get; set; }

        public int InstallmentTypeId { get; set; }
        public InstallmentType InstallmentType { get; set; }

        public ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
