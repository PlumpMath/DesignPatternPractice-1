using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary.Decorator
{
    public class SoyMilk: Beverage
    {
        public override string desc()
        {
            return "Soy Milk";
        }
        public override double price()
        {
            return 40;
        }
    }
}
