using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class FormOfPayment : Entity
    {
        public string Type { get; set; }

        public Guid InstallmentTypeId { get; set; }
        public InstallmentType InstallmentType { get; set; }
    }
}
