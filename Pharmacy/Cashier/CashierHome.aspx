<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CashierHome.aspx.cs" Inherits="Pharmacy.Cashier.CashierHome" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cashier home</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Welcome cashier</h1>
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods = "true">
        </asp:ScriptManager>
        <asp:TextBox ID="SearchTextBox" runat="server" Height="16px" Width="411px"></asp:TextBox>
        <asp:AutoCompleteExtender ID="SearchAutoCompleteExtender" runat="server" MinimumPrefixLength="2" CompletionInterval="100"
            CompletionSetCount="10" TargetControlID="SearchTextBox" FirstRowSelected="false" EnableCaching="True"
            ServiceMethod="SearchProducts" >
        </asp:AutoCompleteExtender>
        <asp:Button ID="AddButton" runat="server" Text="Add to cart" 
            onclick="AddButton_Click" /><br />
        <br /><br />
        <asp:GridView ID="CartGridView" runat="server" AutoGenerateColumns="False" OnRowCommand="CartGridView_RowCommand" 
            OnRowCancelingEdit="CartGridView_RowCancelingEdit" OnRowEditing="CartGridView_RowEditing" OnRowUpdating="CartGridView_RowUpdating">
            <Columns>
                <asp:TemplateField HeaderText="No">
                    <ItemTemplate>
                        <asp:Label ID="NoLabel" runat="server" Text='<%#Eval("No") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Products">
                    <ItemTemplate>
                        <asp:Label ID="ProductLabel" runat="server" Text='<%#Eval("Products") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Price">
                    <ItemTemplate>
                        <asp:Label ID="priceLabel" runat="server" Text='<%#Eval("Prices") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <%#Eval("Quantity") %>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="QuantityTextBox" runat="server" Text='<%#Eval("Quantity") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ButtonType="Button" ShowEditButton="true" ShowCancelButton="true" HeaderText="Edit quantity"/>
                <asp:ButtonField CommandName="Del" ButtonType="Button" DataTextField="Delete" HeaderText="Delete item" CausesValidation="True" />
            </Columns>
        </asp:GridView>
        Total price: 
        <asp:Label ID="TotalPriceLabel" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="OrderButton" runat="server" Text="Buy" 
            onclick="OrderButton_Click" />
    </div>
    </form>
</body>
</html>
