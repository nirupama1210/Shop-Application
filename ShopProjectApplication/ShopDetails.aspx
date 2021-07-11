<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShopDetails.aspx.cs" MasterPageFile="~/Site3.Master" Inherits="ShopProjectApplication.ShopDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .cl1 {
        background-color:white;
        }
        .auto-style1 {
        background-color: white;
        width: 1090px;
        height: 442px;
    }
        </style>
    <form id="form1" runat="server">
    <div class="auto-style1">
    <center>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" onrowcommand="GridView1_RowCommand" GridLines="None" Height="343px" Width="950px" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ShopId" HeaderText="Shop ID">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="ShopName" HeaderText="Name">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Shop_phone" HeaderText="Contact No.">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Shop_address" HeaderText="Address">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="ShopEmail" HeaderText="Email">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="">
        <ItemTemplate>
           <asp:Button ID="btn" runat="server" Text="View Products" ButtonType="LinkButton" CommandName="View" CommandArgument='<%# Container.DataItemIndex%>' />
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
