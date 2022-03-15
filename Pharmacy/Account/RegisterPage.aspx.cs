﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using BLL;

namespace Pharmacy
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            string url = "~/StopOver/WelcomePage.aspx";
            BLL.controlMembership.RegisterUser(UserNameTextBox.Text, PasswordTextBox.Text, EmailTextBox.Text, QuestionTextBox.Text, AnswerTextBox.Text, ResponseLabel, url);
        }
    }
}