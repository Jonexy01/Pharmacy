using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Pharmacy.Admin
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                controlRoleManager.PopulateRolesDDL(RoleDropDownList);
            }
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            string url = "~/Admin/Useradded.aspx";
            controlMembership.RegisterUser(UserNameTextBox.Text, PasswordTextBox.Text, EmailTextBox.Text, QuestionTextBox.Text, AnswerTextBox.Text, ResponseLabel, url, RoleDropDownList.Text);
        }
    }
}