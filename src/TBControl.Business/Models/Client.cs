using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class Client : Entity
    {
        public string NameClient { get; set; }
        public string CPF { get; set; }
        public DateTime Brithday { get; set; }
        public DateTime RegistrationDate { get; set; }

        public bool Active { get; set; }

        public Guid ClintAddressId { get; set; }

        public ClientAddress ClintAddress { get; set; }

        public IEnumerable<SalesOrder> SalesOrders { get; set; }
    }
}
