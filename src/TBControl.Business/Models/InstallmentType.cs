using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class InstallmentType: Entity
    {
        InstallmentType()
        {
            this.FormOfPayments = new HashSet<FormOfPayment>();
        }

        public string Modality { get; set; }
        public decimal Interest { get; set; }

        public ICollection<FormOfPayment> FormOfPayments { get; set; }
    }
}
