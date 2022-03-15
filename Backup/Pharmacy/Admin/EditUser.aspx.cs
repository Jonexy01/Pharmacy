using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Pharmacy.Admin
{
    public partial class EditUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string aUser = (string)Session["user"];
                UserLabel.Text = aUser;

                if (aUser != "Select user")
                {
                    controlRoleManager.PopulateRolesDDL(RoleDropDownList, aUser);
                }
            }
        }

        protected void RoleDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlRoleManager.ChangeUserRole(UserLabel.Text, RoleDropDownList);
        }
    }
}