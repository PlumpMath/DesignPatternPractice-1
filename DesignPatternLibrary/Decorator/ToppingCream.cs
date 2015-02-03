using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary.Decorator
{
    public class ToppingCream: Topping
    {
        public ToppingCream(Beverage bev) 
        {
            parentObj = bev;
        }

        public override string desc()
        {
            return parentObj.desc() + " with cream";
        }
        public override double price()
        {
            return parentObj.price() + 2;
        }
    }
}
