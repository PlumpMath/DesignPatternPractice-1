using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary.Decorator
{
    public class ToppingCaramel: Topping
    {
        public ToppingCaramel(Beverage bev) 
        {
            parentObj = bev;
        }

        public override string desc()
        {
            return parentObj.desc() + " with caramel";
        }

        public override double price()
        {
            return parentObj.price() + 1;
        }
    }
}
