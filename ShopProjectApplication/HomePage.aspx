<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site3.Master" CodeBehind="HomePage.aspx.cs" Inherits="ShopProjectApplication.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .auto-style4 {
            background-color: #B5CDFF;
        }
        .auto-style5 {
            background-color: #4F91FF;
        }
        .cbstyle {
        background-color:white;
        }
        .auto-style6 {
            background-color: white;
            width: 1082px;
        }
    </style>

    <form id="form1" runat="server">
        <center>
            <div class="auto-style6">
<asp:CheckBox ID="CheckBox1" runat="server" Text="Food-Item" Checked="true" AutoPostBack="true" Height="27px" OnCheckedChanged="CheckBox1_CheckedChanged" Width="122px"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
<asp:CheckBox ID="CheckBox2" runat="server" Text="Bags" Checked="true" AutoPostBack="true" OnCheckedChanged="CheckBox2_CheckedChanged" Height="27px" Width="122px"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
<asp:CheckBox ID="CheckBox3" runat="server" Text="Shoes" Checked="true" AutoPostBack="true" OnCheckedChanged="CheckBox3_CheckedChanged" Height="27px" Width="122px"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
<asp:CheckBox ID="CheckBox4" runat="server" Text="Clothes" Checked="true" AutoPostBack="true" OnCheckedChanged="CheckBox4_CheckedChanged" Height="27px" Width="122px"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
<asp:CheckBox ID="CheckBox5" runat="server" Text="Paintings" Checked="true" AutoPostBack="true" OnCheckedChanged="CheckBox5_CheckedChanged" Height="27px" Width="122px"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox6" runat="server" Text="Others" Checked="true" AutoPostBack="true" OnCheckedChanged="CheckBox6_CheckedChanged" Height="27px" Width="122px"></asp:CheckBox>&nbsp;&nbsp;&nbsp;<br /><br />
                </div>
        <asp:DataList ID="DataList1" runat="server"  RepeatColumns="3" OnItemCommand="DataList1_ItemCommand" OnItemDataBound="Image1" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" CssClass="auto-style4">
            <ItemTemplate>
                <table class="auto-style1" border="1">
                    <tr>
                        <td>Shop Name:
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("ShopName") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Product Name:
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("ProdName") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Category") %>'></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label5" runat="server" Text='<%# Eval("size") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Image ID="Image1" runat="server" Height="200px" Width="350px" ImageUrl='<%# ToBase64(Eval("ProdImage")) %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>Price:
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Button ID="Button1" CausesValidation="True" UseSubmitBehavior="False" runat="server" Text="Add to Cart" CommandArgument='<%# Eval("ProdID")+","+Eval("ShopID")+","+Eval("Size")%>' CommandName="addtocart" CssClass="auto-style5"/>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Button ID="Button2" CausesValidation="True" UseSubmitBehavior="False" runat="server" Text="Show Details" CommandArgument='<%# Eval("ProdID")+","+Eval("ShopID")%>' CommandName="viewdetails" OnClick="Button2_Click" CssClass="auto-style5" />
                        </td>
                    </tr>
                </table>
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
          
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShopDBConnectionString %>" SelectCommand="SELECT [ProdName], [Category], [Price], [Size], [ProdImage] FROM [prodtbl]"></asp:SqlDataSource>
     </center> </form>
</asp:Content>

