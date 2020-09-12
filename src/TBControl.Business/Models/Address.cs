using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public abstract class Address : Entity
    {
        public string StreetAddress { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string ZipeCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string UF { get; set; }
    }
}
