<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="Pharmacy.Sales.ErrorPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Error page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Unable to complete sale</h1>
        <h5>Make sure you have entered correct and matching user, serial and date</h5>
        <h5>Ensure this sale has not been completed prior to this time</h5>
        <h5>If problem persist, contact the software admin</h5>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Sales/SalesHome.aspx">Home</asp:LinkButton>
    </div>
    </form>
</body>
</html>
