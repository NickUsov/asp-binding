using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public interface IDiscountProvider
    {
        double ApplyDiscount(double totalSum);
        double Discount { get; set; }
    }
}
