<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalesHome.aspx.cs" Inherits="Pharmacy.Sales.SalesHome" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sales</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods = "true">
        </asp:ScriptManager>
        <h1>Welcome salesperson</h1>
        Cashier: 
        <asp:DropDownList ID="CashierDropDownList" runat="server" 
            AppendDataBoundItems="True">
            <asp:ListItem Text="Select cashier" Selected="True"></asp:ListItem>
        </asp:DropDownList><br />
        Serial(numbers only): 
        <asp:TextBox ID="SerialTextBox" runat="server"></asp:TextBox><br />
        Date(mm/dd/yyyy):<asp:TextBox ID="DateTextBox" runat="server" Text="Today" Enabled="true"></asp:TextBox><br />
        <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="DateTextBox">
        </asp:CalendarExtender>
        <asp:Button ID="SellButton" runat="server" Text="Sell" 
            onclick="SellButton_Click" />
    </div>
    </form>
</body>
</html>
