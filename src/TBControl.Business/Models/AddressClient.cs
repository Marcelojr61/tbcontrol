using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class AddressClient : Address
    {
        public Client Client { get; set; }
    }
}
