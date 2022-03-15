using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Web.Security;

namespace Pharmacy.Admin
{
    public partial class ManageUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                controlMembership.PopulateUsersDDL(UserDropDownList);
            }
        }

        protected void UserDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserDropDownList.SelectedIndex == 0)
            {
                InfoPanel.Visible = false;
            }
            else
            {
                InfoPanel.Visible = true;
                controlMembership.DisplayUserInfo(UserDropDownList.Text, CreatedLabel, LastLogonLabel, OnlineLabel, LockedOutLabel, YesRadioButton, NoRadioButton);
            }
            controlMisc.RefreshUserDDL(UserDropDownList, UserLabel);
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("~/Admin/AddUser.aspx");
        }

        protected void LockedOutButton_Click(object sender, EventArgs e)
        {
            controlMembership.UnlockUser(UserDropDownList.Text, LockedOutLabel);
            LockedOutLabel.EnableViewState = false;
            LockedOutButton.Visible = false;
        }

        protected void YesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (YesRadioButton.Checked)
            {
                controlMembership.AuthorizeUser(UserDropDownList.Text);
                NoRadioButton.Checked = false;
            }
        }

        protected void NoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NoRadioButton.Checked)
            {
                controlMembership.UnAuthorizeUser(UserDropDownList.Text);
                YesRadioButton.Checked = false;
            }
        }

        protected void RefreshButton_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("~/Admin/ManageUsers.aspx");
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            controlMembership.RemoveUser(UserDropDownList.Text);
            HttpContext.Current.Response.Redirect("~/Admin/ManageUsers.aspx");
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            Session["user"] = UserDropDownList.Text;
            HttpContext.Current.Response.Redirect("~/Admin/EditUser.aspx");
        }
    }
}