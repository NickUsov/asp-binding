using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class DefaultDiscountProvider : IDiscountProvider
    {
        public double Discount { get; set; } = 5;
        public double ApplyDiscount(double totalSum)
        {
            return (100 - Discount) * totalSum / 100;
        }
    }
}