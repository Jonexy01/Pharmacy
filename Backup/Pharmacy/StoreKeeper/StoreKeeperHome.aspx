<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StoreKeeperHome.aspx.cs" Inherits="Pharmacy.StoreKeeper.StoreKeeperHome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Store keeper home</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Welcome store keeper</h1>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/StoreKeeper/UpdateProduct.aspx">Update products</asp:LinkButton>
    </div>
    </form>
</body>
</html>
