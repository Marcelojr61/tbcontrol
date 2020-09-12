using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class Client : Entity
    {
        Client()
        {
            this.SalesOrders = new HashSet<SalesOrder>();
            this.RegistrationDate = DateTime.Now;
        }

        public string Name { get; set; }
        public string CPF { get; set; }
        public DateTime Brithday { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Active { get; set; }

        public Guid AddressClientId { get; set; }
        public AddressClient AddressClient { get; set; }

        public ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
