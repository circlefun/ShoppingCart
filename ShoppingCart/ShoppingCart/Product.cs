using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Product
    {
        public Product(char name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public char Name { get; set; }
        public decimal Price { get; set; }
        public Promotion Promotion { get; set; }
        public decimal Total(int units)
        {
            if (Promotion != null)
            {
                int sets = units / Promotion.Units;
                int singles = units % Promotion.Units;
                return (sets * Promotion.Amount) + (singles * Price);
            }
            else
            {
                return units * Price;
            }
        }
    }
}
