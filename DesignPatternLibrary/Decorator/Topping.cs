using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary.Decorator
{
    public abstract class Topping: Beverage
    {
        protected Beverage parentObj;
    }
}
