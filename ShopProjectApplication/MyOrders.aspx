<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site3.Master" CodeBehind="MyOrders.aspx.cs" Inherits="ShopProjectApplication.MyOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 1087px;
            background-color:white;
        height: 490px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div class="auto-style1">
        Your Orders<br />
        <br />
        <center>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="360px" Width="495px" EmptyDataText="No Orders Available" OnRowCommand="GridView1_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="OrderID" HeaderText="Order ID" >
                 <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                 <asp:BoundField DataField="OrderDate" HeaderText="Order Date" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                 <asp:BoundField DataField="Total" HeaderText="Total Price" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="">
        <ItemTemplate>
           <asp:Button ID="btnShow" runat="server" Text="Show More" ButtonType="LinkButton" CommandName="Show" CommandArgument='<%# Container.DataItemIndex%>' />
        </ItemTemplate>
        </asp:TemplateField>
                <asp:TemplateField>
            <ItemTemplate>
                
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" CssClass = "ChildGrid" CellPadding="3" ForeColor="#333333" GridLines="None" Height="200px" Width="350px">
                        <Columns>
                            <asp:BoundField ItemStyle-Width="150px" DataField="ProdID" HeaderText="Product ID" />
                            <asp:BoundField ItemStyle-Width="150px" DataField="ShopID" HeaderText="Shop ID" />
                            <asp:BoundField ItemStyle-Width="150px" DataField="Size" HeaderText="Size" />
                            
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                         <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                           <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
           
            </ItemTemplate>
        </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
            </center>
    </div>
    </form>
    </asp:Content>
