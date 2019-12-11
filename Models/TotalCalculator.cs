using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class TotalCalculator:ICalculator
    {
        public double CalculatePrice(IEnumerable<Good> goods)
        {
            return provider.ApplyDiscount( goods.Sum(g => g.Price));
        }
        private readonly IDiscountProvider provider;
        public TotalCalculator(IDiscountProvider provider)
        {
            this.provider = provider;
        }
    }
}