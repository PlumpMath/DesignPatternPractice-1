using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary.ObserverMode
{
    public class SubBoard1: IObserver
    {
        private StockData stock;
        private string StockName;
        private int StockCount;
        private double StockPrice;

        public SubBoard1(StockData myStock)
        {
            stock = myStock;
            stock.registerObserver(this);
        }

        public void updateSubjectData(string stkName, int stkCount, double stkPrice)
        {
            StockName = stkName;
            StockCount = stkCount;
            StockPrice = stkPrice;
        }
        public string dispResult()
        {
            string dispText = "";
            dispText = "SubBoard1" + "StockName:" + StockName + "StockCount:" + StockCount.ToString() + "StockPrice:" + StockPrice.ToString();
            return dispText;
        }

    }
}
