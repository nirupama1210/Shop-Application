<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site4.Master"  CodeBehind="AdminDisplayShop.aspx.cs" Inherits="ShopProjectApplication.AdminDisplayShop" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div>
        <span class="auto-style1">Approved Shops
       
        </span>
       
        <br />
    <br /><br />
        <center>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"  EmptyDataText="No Shops Available" CellPadding="4" DataKeyNames="ShopId" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="435px" Width="718px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ShopId" HeaderText="ShopId" ReadOnly="True" SortExpression="ShopId" />
                <asp:BoundField DataField="ShopName" HeaderText="ShopName" SortExpression="ShopName" />
                <asp:BoundField DataField="Shop_phone" HeaderText="Shop_phone" SortExpression="Shop_phone" />
                <asp:BoundField DataField="Shop_address" HeaderText="Shop_address" SortExpression="Shop_address" />
                <asp:BoundField DataField="ShopEmail" HeaderText="ShopEmail" SortExpression="ShopEmail" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShopDBConnectionString %>" SelectCommand="SELECT [ShopId], [ShopName], [Shop_phone], [Shop_address], [ShopEmail] FROM [shoptbl] WHERE ([Approved] = @Approved)">
            <SelectParameters>
                <asp:Parameter DefaultValue="True" Name="Approved" Type="Boolean" />
            </SelectParameters>
        </asp:SqlDataSource>
    </center>
    </div>
    </form>
</asp:Content>
