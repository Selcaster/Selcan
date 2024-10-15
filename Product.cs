using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Product
    {
        public string BrandName { get; set; }
        public double Price { get; set; }
    }
    public Product(string BrandName, double Price) 
    {
        this.Brandname = BrandName;
        this.Price = Price;
    }
}
