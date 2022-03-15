<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalesSuccess.aspx.cs" Inherits="Pharmacy.Sales.SalesSuccess" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sales success</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Sale successfully completed</h1>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Sales/SalesHome.aspx">Go to sales home page</asp:LinkButton>
    </div>
    </form>
</body>
</html>
