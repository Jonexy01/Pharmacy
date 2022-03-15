using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pharmacy.StoreKeeper
{
    public partial class EditProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DetailView_ItemInsert(object sender, DetailsViewInsertedEventArgs e)
        {
            if (e.AffectedRows == 1)
            {
                AddResponseLabel.Text = "Inserted successfully";
                AddButton.Visible = true;
            }
        }

        protected void DetailView_ItemCommand(object sender, DetailsViewCommandEventArgs e)
        {
            if (e.CommandName == "Cancel")
            {
                AddResponseLabel.Text = "";
                AddButton.Visible = true;
            }
        }

        protected void DetailView_ItemInserting(object sender, DetailsViewInsertEventArgs e)
        {
            if (AddDetailsView.CurrentMode == DetailsViewMode.Insert)
            {
                TextBox tb = (TextBox)AddDetailsView.FindControl("Last_updateTextBox");
                string dt = DateTime.Now.ToString();
                tb.Visible = true;
                tb.Text = dt;
                tb.Visible = false;
            }
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            AddDetailsView.Visible = true;
            AddButton.Visible = false;
        }
    }
}