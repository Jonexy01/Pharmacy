using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

namespace Pharmacy.Sales
{
    public partial class SalesHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                controlRoleManager.PopulateCashierDDL(CashierDropDownList);
            }
        }

        protected void SellButton_Click(object sender, EventArgs e)
        {
            bool sell;
            if (DateTextBox.Text == "Today")
            {
                sell = myCRUD.UpdateCompleted(CashierDropDownList.Text, Convert.ToInt32(SerialTextBox.Text));
            }
            else
            {
                sell = myCRUD.UpdateCompleted(CashierDropDownList.Text, Convert.ToInt32(SerialTextBox.Text), DateTextBox.Text);
            }
            if (sell == true)
            {
                HttpContext.Current.Response.Redirect("~/Sales/SalesSuccess.aspx");
            }
            else
            {
                HttpContext.Current.Response.Redirect("~/Sales/ErrorPage.aspx");
            }
        }
    }
}