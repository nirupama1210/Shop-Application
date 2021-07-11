<%@ Page Language="C#"  MasterPageFile="~/Site3.Master"AutoEventWireup="true" CodeBehind="AddCart.aspx.cs" Inherits="ShopProjectApplication.AddCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .auto-style1 {
            background-color: #99D5FD;
        }
        .div1 {
         background-color:rgb(237,237,237);
        }
    </style>

    <form id="form1" runat="server">
    <div class="div1">
    <center>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" EmptyDataText="Product Cart is Empty" ForeColor="#333333" Height="458px" Width="1073px" onrowcommand="GridView1_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ProdID" HeaderText="Product ID">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="ShopID" HeaderText="Shop ID">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="ProdName" HeaderText="Product Name">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="ShopName" HeaderText="Shop Name">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="size" HeaderText="Size">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Price" HeaderText="Price">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:TemplateField>
            <ItemTemplate>
                    <img src="<%# Eval("ProdImage") %>" height="200" width="350"/>
        </ItemTemplate>
                    </asp:TemplateField>
                     

                  <asp:BoundField DataField="Quantity" HeaderText="Quantity">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="TPrice" HeaderText="Total Price">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="">
        <ItemTemplate>
           <asp:Button ID="btnRem" runat="server" Text="Remove" ButtonType="LinkButton" CommandName="Remove" CommandArgument='<%# Container.DataItemIndex%>' />
        </ItemTemplate>
        </asp:TemplateField>
                <asp:TemplateField HeaderText="">
        <ItemTemplate>
           <asp:Button ID="btnMod" runat="server" Text="Modify" ButtonType="LinkButton" CommandName="Modify" CommandArgument='<%# Container.DataItemIndex%>' />
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
        <br />
    </center>
    
        <center>
        <asp:Button ID="Button1" runat="server" Text="Place Order" CssClass="auto-style1" Height="43px" OnClick="Button1_Click" Width="198px" Visible="false"/>
            </center>
        </div>
    </form>
   </asp:Content>
