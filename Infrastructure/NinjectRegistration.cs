﻿using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Infrastructure
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            Bind<ICalculator>().To<TotalCalculator>();
            Bind<IDiscountProvider>().To<DefaultDiscountProvider>();
        }
    }
}