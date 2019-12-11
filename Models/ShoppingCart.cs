using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ShoppingCart
    {
        private readonly ICalculator Calculator;
        public IEnumerable<Good> Goods { get; set; }
       // public ICalculator Calculator = new TotalCalculator();
       public ShoppingCart(ICalculator calc)
        {
            this.Calculator = calc;
        }
        public double TotalPrice()
        {
            return Calculator.CalculatePrice(Goods);
        }
    }
}