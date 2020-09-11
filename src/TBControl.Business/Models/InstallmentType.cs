using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class InstallmentType : Entity
    {
        public string Modality { get; set; }
        public decimal Interest { get; set; }
    }
}
