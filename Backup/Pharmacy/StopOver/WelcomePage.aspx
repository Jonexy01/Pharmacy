<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomePage.aspx.cs" Inherits="Pharmacy.WelcomePage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Welcome 
            <asp:LoginName ID="LoginName1" runat="server" />
        </h1>
        <asp:LinkButton ID="ContinueLinkButton" runat="server" 
            onclick="ContinueLinkButton_Click">continue</asp:LinkButton><br />
        <asp:Label ID="ContinueLabel" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
