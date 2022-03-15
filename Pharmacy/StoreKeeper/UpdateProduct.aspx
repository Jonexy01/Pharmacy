<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="Pharmacy.StoreKeeper.EditProduct" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update product</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Update products</h1>
        <asp:GridView ID="ProductGridView" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="ProductId" DataSourceID="SqlDataSource1" 
            EmptyDataText="There are no data records to display.">
            <Columns>
                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                <%--<asp:BoundField DataField="ProductId" HeaderText="ProductId" ReadOnly="True" 
                    SortExpression="ProductId" />--%>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" ReadOnly="true"/>
                <asp:BoundField DataField="Description" HeaderText="Description" 
                    SortExpression="Description" ReadOnly="true"/>
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" 
                    SortExpression="Quantity" />
                <asp:BoundField DataField="Last_update" HeaderText="Last_update" 
                    SortExpression="Last_update" ReadOnly="true"/>
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
            </Columns>
            <PagerSettings Mode="NumericFirstLast" />
        </asp:GridView><br />
        <asp:Button ID="AddButton" runat="server" Text="Add Product" 
            onclick="AddButton_Click" />
        <asp:Label ID="AddResponseLabel" runat="server" Text="" EnableViewState="false"></asp:Label><br />
        <asp:DetailsView ID="AddDetailsView" runat="server" AutoGenerateRows="False" DefaultMode="Insert"
            Visible="false" DataKeyNames="ProductId" DataSourceID="SqlDataSource1" Height="50px" OnItemInserting="DetailView_ItemInserting"
            Width="125px" EnableViewState="false" OnItemInserted="DetailView_ItemInsert" OnItemCommand="DetailView_ItemCommand" >
            <Fields>
                <%--<asp:BoundField DataField="ProductId" HeaderText="ProductId" 
                    InsertVisible="False" ReadOnly="True" SortExpression="ProductId" />--%>
                <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>'>
                            </asp:TextBox>
                            <asp:RequiredFieldValidator ID="NameRequiredFieldValidator" runat="server" ErrorMessage="Name required" 
                                ControlToValidate="NameTextBox" Display="Dynamic">
                            </asp:RequiredFieldValidator>
                        </ItemTemplate>
                    </asp:TemplateField>
                <%--<asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />--%>
                <asp:TemplateField HeaderText="Description">
                        <ItemTemplate>
                            <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("Description") %>'>
                            </asp:TextBox>
                            <asp:RequiredFieldValidator ID="DesciptionRequiredFieldValidator" runat="server" ErrorMessage="Description required" 
                                ControlToValidate="DescriptionTextBox" Display="Dynamic">
                            </asp:RequiredFieldValidator>
                        </ItemTemplate>
                    </asp:TemplateField>
                <%--<asp:BoundField DataField="Description" HeaderText="Description" 
                    SortExpression="Description" />--%>
                <asp:TemplateField HeaderText="Price">
                        <ItemTemplate>
                            <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>'>
                            </asp:TextBox>
                            <asp:RequiredFieldValidator ID="PriceRequiredFieldValidator" runat="server" ErrorMessage="Price required" 
                                ControlToValidate="PriceTextBox" Display="Dynamic">
                            </asp:RequiredFieldValidator>
                            <%--<asp:CompareValidator ID="PriceCompareValidator" runat="server" ErrorMessage="Integer required" 
                                ControlToValidate="PriceTextBox" Type="Integer" Display="Dynamic">
                            </asp:CompareValidator>--%>
                        </ItemTemplate>
                    </asp:TemplateField>
                <%--<asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />--%>
                <asp:TemplateField HeaderText="Quantity">
                        <ItemTemplate>
                            <asp:TextBox ID="QuantityTextBox" runat="server" Text='<%# Bind("Quantity") %>'>
                            </asp:TextBox>
                            <asp:RequiredFieldValidator ID="QuantityRequiredFieldValidator" runat="server" ErrorMessage="Quantity required" 
                                ControlToValidate="QuantityTextBox" Display="Dynamic">
                            </asp:RequiredFieldValidator>
                            <%--<asp:CompareValidator ID="QuantityCompareValidator" runat="server" ErrorMessage="Integer required" 
                                ControlToValidate="QuantityTextBox" Type="Integer" Display="Dynamic">
                            </asp:CompareValidator>--%>
                        </ItemTemplate>
                    </asp:TemplateField>
                <%--<asp:BoundField DataField="Quantity" HeaderText="Quantity" 
                    SortExpression="Quantity" />--%>
                <asp:TemplateField HeaderText="Last_update" >
                        <ItemTemplate>
                            <asp:TextBox ID="Last_updateTextBox" runat="server" Text='<%# Bind("Last_update") %>' Visible="false">
                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                <%--<asp:BoundField DataField="Last_update" HeaderText="Last_update" 
                    SortExpression="Last_update" />--%>
                <asp:CommandField ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/StoreKeeper/StoreKeeperHome.aspx">Home</asp:LinkButton>

    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:CString %>" 
        DeleteCommand="DELETE FROM [Product] WHERE [ProductId] = @ProductId" 
        InsertCommand="INSERT INTO [Product] ([Name], [Description], [Price], [Quantity], [Last update]) VALUES (@Name, @Description, @Price, @Quantity, @Last_update)" 
        ProviderName="<%$ ConnectionStrings:CString.ProviderName %>" 
        SelectCommand="SELECT [ProductId], [Name], [Description], [Price], [Quantity], [Last update] AS Last_update FROM [Product]" 
        UpdateCommand="UPDATE [Product] SET [Name] = @Name, [Description] = @Description, [Price] = @Price, [Quantity] = @Quantity, [Last update] = @Last_update WHERE [ProductId] = @ProductId">
        <DeleteParameters>
            <asp:Parameter Name="ProductId" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="Price" Type="Int32" />
            <asp:Parameter Name="Quantity" Type="Int32" />
            <asp:Parameter DbType="Date" Name="Last_update" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="Price" Type="Int32" />
            <asp:Parameter Name="Quantity" Type="Int32" />
            <asp:Parameter DbType="Date" Name="Last_update" />
            <asp:Parameter Name="ProductId" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    </form>
</body>
</html>
