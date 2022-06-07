using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Promotion
    {
        public Promotion(int units, decimal amount)
        {
            Units = units;
            Amount = amount;
        }
        public int Units { get; set; }
        public decimal Amount { get; set; }
    }
}
