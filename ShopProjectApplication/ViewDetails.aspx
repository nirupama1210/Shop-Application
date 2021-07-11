<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site3.Master" CodeBehind="ViewDetails.aspx.cs" Inherits="ShopProjectApplication.ViewDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 548px;
            background-color:rgb(237,237,237);
        }
        .auto-style2 {
            width: 258px;
        }
    </style>

    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <br />
        <table class="auto-style1">
            <tr>
                <td rowspan="8" class="auto-style2">
                   &nbsp; <asp:Image ID="Image1" runat="server" Height="249px" Width="539px" />
                </td>
                <td>Shop  &nbsp;
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                
                <td>Product  &nbsp;
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                
                <td>Category  &nbsp;
                    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
               
                <td>
                    <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
                </td>
            </tr>
            <tr>
                
                <td>Price&nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Visible="false" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
               
                <td>&nbsp;</td>
            </tr>
            <tr>
               
                <td>Address:
                    <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                
                <td >
                    Quantity <asp:DropDownList ID="DropDownList2" runat="server" Enabled="false">
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Add to Cart" OnClick="Button1_Click" />
                    <br />
                    <br />
                    <asp:Label ID="Label8" runat="server" Text="" Visible="false"></asp:Label>
                    
                </td>
            </tr>
        </table>
        <br />
    
    </div>
    </form>

    </asp:Content>
