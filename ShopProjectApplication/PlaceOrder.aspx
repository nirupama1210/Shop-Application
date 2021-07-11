<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlaceOrder.aspx.cs" Inherits="ShopProjectApplication.PlaceOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 75%;
            height: 49px;
        }
        .auto-style2 {
            width: 89%;
            height: 183px;
            background-color: #ADC6FE;
        }
        .auto-style3 {
            height: 39px;
        }
        .auto-style4 {
            height: 37px;
        }
        .auto-style5 {
            width: 384px;
        }
        .auto-style6 {
            width: 652px;
        }
        .auto-style7 {
            margin-top: 0px;
        }
        .auto-style8 {
            background-color: #6699FF;
        }
        .auto-style9 {
            height: 37px;
            width: 470px;
        }
        .auto-style10 {
            height: 39px;
            width: 470px;
        }
        .auto-style11 {
            margin-left: 0px;
            background-color: #99CCFF;
        }
        .auto-style12 {
            background-color: #99CCFF;
        }
    </style>
</head>
<body>
    <p>
        <br />
    </p>
    <form id="form1" runat="server">
        <div>
        <center>
        <asp:Panel ID="Panel1" runat="server">
            
        
    <table class="auto-style1" border="1">
        <tr>
            <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Order ID</td>
            <td class="auto-style4">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp; Order Date&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    <div>
    
        <br />
        <br />
        


        <asp:GridView ID="GridView1" border="1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="378px" ShowFooter="True" Width="1326px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ProdID" HeaderText="Product ID">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="ProdName" HeaderText="Product Name">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Price" HeaderText="Price">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Quantity" HeaderText="Quantity">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Size" HeaderText="Size">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="TPrice" HeaderText="Total Price">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#9cccff" Font-Bold="True" ForeColor="Black" Height="50px" />
            <HeaderStyle BackColor="#9cccff" Font-Bold="True" ForeColor="Black" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
            
        <br />
        <asp:Label ID="add" runat="server" Text="" Visible="false"></asp:Label>
        <asp:Label ID="mode" runat="server" Text="" Visible="false"></asp:Label>
        <asp:Label ID="disc" runat="server" Text="" Visible="false"></asp:Label>
           </div>   
  </asp:Panel>
        </center>
        <table class="auto-style2">
            <tr>
                <td class="auto-style5">&nbsp;Please enter Address&nbsp;</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style7" Height="111px" Width="707px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="34px" Width="226px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>Cash On Delivery</asp:ListItem>
                        <asp:ListItem>Credit/Debit card</asp:ListItem>
                    </asp:DropDownList>
                </td>
                </tr>
           
        </table>
        <br /><br />
       <center> <asp:Button ID="Button1" runat="server" Text="Check Out" CssClass="auto-style8" Height="57px" Width="253px" OnClick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
           <br />
           <br />
<asp:Button ID="Button3" runat="server" Text="Download Invoice" Visible="false" Height="38px" CssClass="auto-style12" OnClick="Button3_Click"></asp:Button>
           &nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="Button2" runat="server" CssClass="auto-style11" Height="40px" Text="View Orders" Width="150px" Visible="false" OnClick="Button2_Click"/>
        </center>
            </div>
    </form>
</body>
</html>
