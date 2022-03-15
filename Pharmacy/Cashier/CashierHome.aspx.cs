using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using System.Data;
using BLL;

namespace Pharmacy.Cashier
{
    public partial class CashierHome : System.Web.UI.Page
    {
        int aSum;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["CartTable"] = controlMisc.CreateCartTable();
                ViewState["IndexNo"] = 1;
            }
        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string> SearchProducts(string prefixText, int count) 
        {
            List<string> products = myCRUD.FetchSomeProducts(prefixText);
            return products;
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            if (controlMisc.ProductExists(SearchTextBox.Text))
            {
                DataTable dt = (DataTable)ViewState["CartTable"];

                if (controlMisc.RowExist(dt, SearchTextBox.Text))
                {
                    int initQuantity = (int)controlMisc.GetItemByProductName(dt, SearchTextBox.Text, 3);
                    int quantity = initQuantity + 1;
                    DataRow[] daRow = dt.Select("Products = '" + SearchTextBox.Text + "'");
                    daRow[0][3] = quantity;
                }
                else
                {
                    DataRow aRow = dt.NewRow();
                    int indexNo = (int)ViewState["IndexNo"];
                    aRow["No"] = indexNo++;
                    ViewState["IndexNo"] = indexNo;
                    aRow["Products"] = SearchTextBox.Text;

                    int price = myCRUD.FetchPrice(SearchTextBox.Text);
                    aRow["Prices"] = price;
                    aRow["Quantity"] = 1;
                    ButtonField bf = new ButtonField();
                    bf.ButtonType = ButtonType.Button;
                    bf.HeaderText = "remove from cart";
                    bf.CommandName = "Del";
                    bf.Visible = true;
                    bf.CausesValidation = true;
                    aRow["Delete"] = bf;
                    dt.Rows.Add(aRow);
                }
                SearchTextBox.Text = "";

                CartGridView.DataSource = ViewState["CartTable"];
                CartGridView.DataBind();

                aSum = controlMisc.SumColumnValues(dt, 2, 3);
                TotalPriceLabel.Text = aSum.ToString();    
            }
            
            
        }

        protected void CartGridView_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Del")
            {
                int myIndex = Int32.Parse(e.CommandArgument.ToString());
                DataTable dtNew = (DataTable)ViewState["CartTable"];
                int rowNo = dtNew.Rows.Count;
                rowNo = rowNo - 1;
                dtNew.Rows.RemoveAt(myIndex);
                for (int i = myIndex; i < rowNo; i++)
                {
                    int j = i + 2;
                    DataRow[] daRow = dtNew.Select("No = '" + j + "'");
                    daRow[0][0] = j - 1;
                }
                int _no = (int)ViewState["IndexNo"];
                ViewState["IndexNo"] = _no - 1;
                CartGridView.DataSource = ViewState["CartTable"];
                CartGridView.DataBind();

                aSum = controlMisc.SumColumnValues(dtNew, 2, 3);
                TotalPriceLabel.Text = aSum.ToString();
            }
        }

        protected void CartGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            e.Cancel = true;
            CartGridView.EditIndex = -1;
            CartGridView.DataSource = ViewState["CartTable"];
            CartGridView.DataBind();
        }

        protected void CartGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            CartGridView.EditIndex = e.NewEditIndex;
            CartGridView.DataSource = ViewState["CartTable"];
            CartGridView.DataBind();
        }

        protected void CartGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = CartGridView.Rows[e.RowIndex];
            Label NoLabel = (Label)row.FindControl("NoLabel");
            TextBox QuantityTextBox = (TextBox)row.FindControl("QuantityTextBox");
            int quantity = Int32.Parse(QuantityTextBox.Text);
            DataTable dt = (DataTable)ViewState["CartTable"];
            controlMisc.UpdateCartTable(dt, quantity, int.Parse(NoLabel.Text));
            CartGridView.EditIndex = -1;
            CartGridView.DataSource = ViewState["CartTable"];
            CartGridView.DataBind();

            aSum = controlMisc.SumColumnValues(dt, 2, 3);
            TotalPriceLabel.Text = aSum.ToString();
        }

        protected void OrderButton_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["CartTable"];
            int d = dt.Rows.Count;
            if (d > 0)
            {
                controlMisc.SubmitOrder(dt);
            }
            HttpContext.Current.Response.Redirect("~/Cashier/OrderSuccess.aspx");
        }
    }
}