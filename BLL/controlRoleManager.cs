using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace BLL
{
    public class controlRoleManager
    {
        public static void CreateRole(string _role, Label lb)
        {
            Roles.CreateRole(_role);
            lb.Text = "'" + _role + "'" + " role successfully created.";
        }

        public static void DeleteRole(string _role, Label lb)
        {
            Roles.DeleteRole(_role);
            lb.Text = "'" + _role + "'" + " role successfully deleted.";
        }

        public static void AddUToRole(string _userName, string _roleName, Label lb)
        {
            Roles.AddUserToRole(_userName, _roleName);
            lb.Text = "User added to role successfully";
        }

        public static void AddUToRole(string _userName, string _roleName)
        {
            if (_userName != "select role")
            {
                Roles.AddUserToRole(_userName, _roleName);
            }
        }

        public static void ChangeUserRole(string _user, DropDownList ddl) 
        {
            string[] _roles = Roles.GetRolesForUser(_user);
            Roles.RemoveUserFromRole(_user, _roles[0]);
            Roles.AddUserToRole(_user, ddl.Text);
        }

        public static void RemoveUFromRole(string _userName, string _roleName, Label lb)
        {
            Roles.RemoveUserFromRole(_userName, _roleName);
            lb.Text = "User removed from role successfully";
        }

        public static void RSelectUserDropDownListAction(string _userName, Label lb)
        {
            string _roles = "";
            lb.Text = _userName + " belongs to " + _roles + " role(s).";
        }

        public static void PopulateRolesDDL(DropDownList ddl)
        {
            string[] _roles = Roles.GetAllRoles();
            ddl.DataSource = _roles;
            ddl.DataBind();
        }

        public static void PopulateRolesDDL(DropDownList ddl, string _user) 
        {
            string[] _roles = Roles.GetAllRoles();
            ddl.DataSource = _roles;
            ddl.DataBind();

            string[] roles =  Roles.GetRolesForUser(_user);
            ddl.SelectedValue = roles[0];
        }

        public static void PopulateCashierDDL(DropDownList ddl) 
        {
            string[] _cashiers = Roles.GetUsersInRole("Cashier");
            ddl.DataSource = _cashiers;
            ddl.DataBind();
        }

        public static void GetUsersInRole(string _role, DropDownList ddl)
        {
            string[] someUsers = Roles.GetUsersInRole(_role);
            ddl.DataSource = someUsers;
            ddl.DataBind();
        }

        
    }
}
