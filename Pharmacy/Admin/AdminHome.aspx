<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="Pharmacy.Admin.AdminHome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin home</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Welcome Admin</h1>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Admin/ManageUsers.aspx">Manage users</asp:LinkButton><br />
        <asp:LinkButton ID="LinkButton2" runat="server">View sales</asp:LinkButton>
    </div>
    </form>
</body>
</html>
