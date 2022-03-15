<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageUsers.aspx.cs" Inherits="Pharmacy.Admin.ManageUsers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Manage users</h1>
        <asp:DropDownList ID="UserDropDownList" runat="server" 
            AutoPostBack="true" AppendDataBoundItems="True" 
            onselectedindexchanged="UserDropDownList_SelectedIndexChanged" 
            Width="119px">
        <asp:ListItem Text="Select user" Selected="True"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Panel ID="ButtonsPanel" runat="server">
            <asp:Button ID="AddButton" runat="server" Text="Add" 
                onclick="AddButton_Click" />
            <asp:Button ID="DeleteButton" runat="server" Text="Delete" OnClientClick="return alert('Are you sure you want to delete user?')" 
                style="margin-left: 49px" onclick="DeleteButton_Click" /><br /><br />
            <asp:Button ID="EditButton" runat="server" Text="Edit" 
                onclick="EditButton_Click" />
            <asp:Button ID="RefreshButton" runat="server" Text="Refresh" 
                style="margin-left: 49px" onclick="RefreshButton_Click" />
        </asp:Panel>
        <asp:Panel ID="InfoPanel" runat="server" Visible="False">
            <h3><asp:Label ID="UserLabel" runat="server" Text=""></asp:Label> information</h3>
            Account created on: 
            <asp:Label ID="CreatedLabel" runat="server" Text=""></asp:Label><br />
            Last logon: 
            <asp:Label ID="LastLogonLabel" runat="server" Text=""></asp:Label>
            <br />
            User is
            <asp:Label ID="OnlineLabel" runat="server" Text=""></asp:Label>
            online.<br />
            <h5>-Authorization</h5>
            User allowed to logon? <br />
            <%--<asp:RadioButtonList ID="ApprovedRadioButtonList" runat="server" 
                AutoPostBack="true" 
                onselectedindexchanged="ApprovedRadioButtonList_SelectedIndexChanged" >
                <asp:ListItem Text="Yes"></asp:ListItem>
                <asp:ListItem Text="No"></asp:ListItem>
            </asp:RadioButtonList><br />--%>
            <asp:RadioButton ID="YesRadioButton" runat="server" Text="Yes" AutoPostBack="true" 
                oncheckedchanged="YesRadioButton_CheckedChanged" /><br />
            <asp:RadioButton ID="NoRadioButton" runat="server" Text="No" AutoPostBack="true" 
                oncheckedchanged="NoRadioButton_CheckedChanged" /><br />
            <asp:Label ID="LockedOutLabel" runat="server" Text="User is locked out" Visible="False"></asp:Label>
            <asp:Button ID="LockedOutButton" runat="server" Text="Unlock" Visible="False" 
                onclick="LockedOutButton_Click" />
        </asp:Panel>
        <br /><br /><br />
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Admin/AdminHome.aspx">Home(admin)</asp:LinkButton>
    </div>
    </form>
</body>
</html>
