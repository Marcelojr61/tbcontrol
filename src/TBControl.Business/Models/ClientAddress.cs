using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class ClientAddress : BaseAddress
    {
        public Guid ClientId { get; set; }

        public Client Client { get; set; }
    }
}
