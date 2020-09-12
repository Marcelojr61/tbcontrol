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
        }

        public string NameClient { get; set; }
        public string CPF { get; set; }
        public DateTime Brithday { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Active { get; set; }

        public Guid AddressId { get; set; }
        public Address Address { get; set; }

        public ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
