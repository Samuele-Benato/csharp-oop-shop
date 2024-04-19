using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Product
    {
       
        private int _code;
        public int Code
        {
            get { return _code; }
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal IVA { get; set; }

        public Product(string name, string description, decimal price, decimal iva)
        {
            _code = CodeGeneration();
            Name = name;
            Description = description;
            Price = price;
            IVA = iva;
        }

        private int CodeGeneration()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 99999);
        }

        public decimal GetPrice()
        {
            return Price;
        }

        public decimal PriceWhitIva()
        {
            decimal priceWhitIva = Price * (1 + IVA / 100);
            return Math.Round(priceWhitIva, 2); 
        }

        public string ExtendedName()
        {
            return Code + " " + Name;
        }
    }
}
