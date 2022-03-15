using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;
using System.Web;
using System.Web.UI.WebControls;
using Model;
using DAL;

namespace BLL
{
    public class controlMembership
    {
        /// <summary>
        /// Attempts to create a user, log the user in and redirect the user to the next page.
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_password"></param>
        /// <param name="_email"></param>
        /// <param name="_question"></param>
        /// <param name="_answer"></param>
        /// <param name="_response"></param>
        /// <returns></returns>
        public static void RegisterUser(string _userName, string _password, string _email, string _question, string _answer, Label _response, string url) 
        {
            MembershipCreateStatus reg;
            MembershipUser user = Membership.CreateUser(_userName, _password, _email, _question, _answer, true, out reg);
            if (reg == MembershipCreateStatus.Success)
            {
                FormsAuthentication.SetAuthCookie(_userName, true);
                HttpContext.Current.Response.Redirect(url);
                //FormsAuthentication.RedirectFromLoginPage(NameTextBox.Text, true);
            }
            else if (reg == MembershipCreateStatus.DuplicateUserName)
            {
                _response.Text = "Username already exist";
            }
            else if (reg == MembershipCreateStatus.DuplicateEmail)
            {
                _response.Text = "Email already exist";
            }
            else if (reg == MembershipCreateStatus.InvalidPassword)
            {
                _response.Text = "Please enter a valid password";
            }
            else if (reg == MembershipCreateStatus.InvalidEmail)
            {
                _response.Text = "Please enter a valid email";
            }
            else
            {
                _response.Text = "Something unexpected happened";
            }
        }

        public static void RegisterUser(string _userName, string _password, string _email, string _question, string _answer, Label _response, string url, string _role)
        {
            MembershipCreateStatus reg;
            MembershipUser user = Membership.CreateUser(_userName, _password, _email, _question, _answer, true, out reg);
            if (reg == MembershipCreateStatus.Success)
            {
                controlRoleManager.AddUToRole(_userName, _role);
                //FormsAuthentication.SetAuthCookie(_userName, true);
                HttpContext.Current.Response.Redirect(url);
            }
            else if (reg == MembershipCreateStatus.DuplicateUserName)
            {
                _response.Text = "Username already exist";
            }
            else if (reg == MembershipCreateStatus.DuplicateEmail)
            {
                _response.Text = "Email already exist";
            }
            else if (reg == MembershipCreateStatus.InvalidPassword)
            {
                _response.Text = "Please enter a valid password";
            }
            else if (reg == MembershipCreateStatus.InvalidEmail)
            {
                _response.Text = "Please enter a valid email";
            }
            else
            {
                _response.Text = "Something unexpected happened";
            }
        }

        public static void RemoveUser(string _userName) 
        {
            if (_userName != "Select user")
            {
                Membership.DeleteUser(_userName);
            }
        }

        public static void LoginUser(string _userName, string _password, Label _response) 
        {
            if (Membership.ValidateUser(_userName, _password))
            {
                FormsAuthentication.SetAuthCookie(_userName, true);
                HttpContext.Current.Response.Redirect("~/StopOver/WelcomePage.aspx");
            }
            else
            {
                _response.Text = "Incorrect username or password";
            }
        }

        public static void LogoutUser() 
        {
            FormsAuthentication.SignOut();
        }

        public static void UnlockUser(string _user, Label lb)
        {
            MembershipUser user = Membership.GetUser(_user);
            user.UnlockUser();
            lb.Text = "User unlocked";
        }

        public static void AuthorizeUser(string _user)
        {
            MembershipUser user = Membership.GetUser(_user);
            user.IsApproved = true;
            Membership.UpdateUser(user);
        }

        public static void UnAuthorizeUser(string _user)
        {
            MembershipUser user = Membership.GetUser(_user);
            user.IsApproved = false;
            Membership.UpdateUser(user);
        }

        public static void PopulateUsersDDL(DropDownList ddl)
        {
            var userList = Membership.GetAllUsers();
            ddl.DataSource = userList;
            ddl.DataBind();
        }

        public static void DisplayUserInfo(string _user, Label _created, Label _lastLogon, Label _onLine, Label _lockedOut, RadioButton _yes, RadioButton _no) 
        {
            MembershipUser user = Membership.GetUser(_user);
            _created.Text = user.CreationDate.ToLongDateString();
            _lastLogon.Text = user.LastLoginDate.ToLongDateString();
            if (user.IsOnline == false)
            {
                _onLine.Text = "not";
            }
            if (user.IsApproved)
            {
                _yes.Checked = true;
                _no.Checked = false;
            }
            else
            {
                _yes.Checked = false;
                _no.Checked = true;
            }
            if (user.IsLockedOut == true)
            {
                _lockedOut.EnableViewState = true;
                _lockedOut.Visible = true;
                _lockedOut.Visible = true;
            }
        }

        public static void ReDirectUserByRole(Label lb)
        {
            MembershipUser user = Membership.GetUser();
            string _name = user.UserName;

            if (Roles.IsUserInRole(_name, "SoftwareAdmin") == true)
            {
                HttpContext.Current.Response.Redirect("~/SoftwareAdmin/SoftwareAdminHome.aspx");
            }
            else if (Roles.IsUserInRole(_name, "Admin") == true)
            {
                HttpContext.Current.Response.Redirect("~/Admin/AdminHome.aspx");
            }
            else if (Roles.IsUserInRole(_name, "StoreKeeper") == true)
            {
                HttpContext.Current.Response.Redirect("~/StoreKeeper/StoreKeeperHome.aspx");
            }
            else if (Roles.IsUserInRole(_name, "Sales") == true)
            {
                HttpContext.Current.Response.Redirect("~/Sales/SalesHome.aspx");
            }
            else if (Roles.IsUserInRole(_name, "Cashier") == true)
            {
                HttpContext.Current.Response.Redirect("~/Cashier/CashierHome.aspx");
            }
            else
            {
                lb.Text = "You need to have a role to continue, please contact the admin";
            }
        }
    }
}
