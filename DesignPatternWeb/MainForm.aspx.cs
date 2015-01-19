using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DesignPatternLibrary.ObserverMode;


namespace DesignPatternWeb
{
    public partial class MainForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlDemoList.Items.Add(new ListItem("Observer Mode", "1"));

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
    }

}