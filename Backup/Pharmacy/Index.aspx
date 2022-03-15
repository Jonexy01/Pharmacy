<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Pharmacy.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Please register or login</h1>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Account/RegisterPage.aspx">Register</asp:LinkButton><br />
        Or 
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Account/Login.aspx">login</asp:LinkButton>
    </div>
    </form>
</body>
</html>
