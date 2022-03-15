<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserAdded.aspx.cs" Inherits="Pharmacy.Admin.UserAdded" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>User added successfully.</h1>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Admin/AdminHome.aspx">Return to admin home page</asp:LinkButton><br />
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Admin/ManageUsers.aspx">Continue managing users</asp:LinkButton><br />
    </div>
    </form>
</body>
</html>
