using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class ProviderAddress : BaseAddress
    {
        public Guid ProviderId { get; set; }
        public Provider Provider { get; set; }

    }
}
