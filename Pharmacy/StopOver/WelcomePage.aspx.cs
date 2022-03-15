using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pharmacy
{
    public partial class WelcomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ContinueLinkButton_Click(object sender, EventArgs e)
        {
            //string username = User.Identity.Name;
            BLL.controlMembership.ReDirectUserByRole(ContinueLabel);
        }
    }
}