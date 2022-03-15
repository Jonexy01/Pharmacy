<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Pharmacy.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Please Login</h1>
        UserName: <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox><br />
        Password: <asp:TextBox ID="PasswordTextBox" runat="server" 
            style="margin-left: 8px" TextMode="Password"></asp:TextBox><br />
        <asp:Button ID="LoginButton" runat="server" Text="Login" 
            onclick="LoginButton_Click" />
        <asp:Label ID="ResponseLabel" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
