using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary.Decorator
{
    public class Tea: Beverage
    {
        public override string desc()
        {
            return "Tea";
        }

        public override double price()
        {
            return 45;
        }
    }
}
