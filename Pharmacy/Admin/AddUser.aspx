﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="Pharmacy.Admin.AddUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Register</h1>
        Username: <asp:TextBox ID="UserNameTextBox" runat="server" 
            style="margin-left: 51px"></asp:TextBox><br />
        Password: <asp:TextBox ID="PasswordTextBox" runat="server" 
            style="margin-left: 53px" TextMode="Password"></asp:TextBox><br />
        Confirm password: <asp:TextBox ID="CPasswordTextBox" runat="server" TextMode="Password"></asp:TextBox><br />
        Email: <asp:TextBox ID="EmailTextBox" runat="server" 
            style="margin-left: 80px"></asp:TextBox><br />
        Security question: <asp:TextBox ID="QuestionTextBox" runat="server" 
            style="margin-left: 9px"></asp:TextBox><br />
        Answer: <asp:TextBox ID="AnswerTextBox" runat="server" 
            style="margin-left: 65px"></asp:TextBox><br />
        Role: <asp:DropDownList ID="RoleDropDownList" 
            runat="server" style="margin-left: 85px" Width="121px">
                <asp:ListItem Text="Select role" Selected="True"></asp:ListItem>
              </asp:DropDownList><br />
        <asp:Button ID="RegisterButton" runat="server" Text="Register" 
            onclick="RegisterButton_Click" /><asp:Label ID="ResponseLabel" runat="server"
            Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
