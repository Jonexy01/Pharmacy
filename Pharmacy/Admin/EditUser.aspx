<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="Pharmacy.Admin.EditUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Edit user</h1>
        <h2><asp:Label ID="UserLabel" runat="server" Text=""></asp:Label></h2>
        Change role: 
        <asp:DropDownList ID="RoleDropDownList" runat="server" AutoPostBack="True" 
            Height="17px" Width="135px" 
            onselectedindexchanged="RoleDropDownList_SelectedIndexChanged">
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
