﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public interface ICalculator
    {
        double CalculatePrice(IEnumerable<Good> goods);
    }
}
