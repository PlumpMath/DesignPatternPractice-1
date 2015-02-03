using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DesignPatternLibrary.ObserverMode;
using DesignPatternLibrary.Decorator;

namespace DesignPatternWeb
{
    public partial class MainForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlDemoList.Items.Add(new ListItem("Observer Mode", "1"));
                ddlDemoList.Items.Add(new ListItem("Decorator", "2"));
            }
            else
            {
                if (ddlDemoList.SelectedValue == "2")
                {
                    pnlDecorator.Visible = true;
                }
            }
        }

        protected void btnRun_Click(object sender, EventArgs e)
        {
            switch (ddlDemoList.SelectedValue.ToString())
            {
                case "1":
                    StockData stk = new StockData();
                    MainBoard mb = new MainBoard(stk);
                    SubBoard1 sb1 = new SubBoard1(stk);
                    SubBoard2 sb2 = new SubBoard2(stk);

                    stk.setMeasurement("STK001", 200, 49.6);

                    lblResult.Text = stk.observerResult();
                    break;
            }
        }


#region "Decorator"
        private Beverage bev;
        protected void beverageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetBeverageDesc();
        }

        private void GetBeverageDesc()
        {
            switch (beverageType.SelectedValue)
            {
                case "C": //Coffee
                    bev = new Coffee();
                    break;
                case "S": //Soymilk
                    bev = new SoyMilk();
                    break;
                case "T": //Tea
                    bev = new Tea();
                    break;
            }
            foreach (ListItem li in toppingList.Items )
            {
                if (li.Selected)
                {
                    switch (li.Value.ToString())
                    {
                        case "C": //Caramel
                            bev = new ToppingCaramel(bev);
                            break;
                        case "D": //Cream
                            bev = new ToppingCream(bev);
                            break;
                        case "W": //Whip
                            bev = new ToppingWhip(bev);
                            break;
                    }
                }
            }

            lblResult.Text = "You have ordered " + bev.desc() + ", and the price is " + bev.price().ToString();
            string toppings = toppingList.SelectedValue;

        }
 
#endregion

    }

}