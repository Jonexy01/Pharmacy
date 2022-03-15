<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderSuccess.aspx.cs" Inherits="Pharmacy.Cashier.OrderSuccess" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Success</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Purchase successfull.</h1>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Cashier/CashierHome.aspx">return to my page</asp:LinkButton>
    </div>
    </form>
</body>
</html>
