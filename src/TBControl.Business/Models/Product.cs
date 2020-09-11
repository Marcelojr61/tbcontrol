using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Models
{
    public class Product : Entity
    {
        public string NameProduct { get; set; }
        public string Description { get; set; }
        public string ModelProduct { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string SerialNumber { get; set; }
        public int Quantity { get; set; }
        public double CostProduct { get; set; }
        public double Price { get; set; }
        public string ImageProduct { get; set; }
    }
}
