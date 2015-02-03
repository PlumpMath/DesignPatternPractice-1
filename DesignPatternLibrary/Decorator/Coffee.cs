﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary.Decorator
{
    public class Coffee: Beverage
    {
        public override string desc()
        {
            return "Coffee";
        }
        public override double price()
        {
            return 50;
        }
    }
}
