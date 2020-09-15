using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class Product : Entity
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string ModelProduct { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string SerialNumber { get; set; }
        public int Quantity { get; set; }
        public double Cost{ get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public OrderedItem OrderedItem { get; set; }
    }
}
