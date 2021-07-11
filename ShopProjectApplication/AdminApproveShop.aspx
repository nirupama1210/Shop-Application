<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site4.Master" CodeBehind="AdminApproveShop.aspx.cs" Inherits="ShopProjectApplication.WebForm1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .auto-style1 {
            background-color: #99CCFF;
        }
    .auto-style2 {
        font-size: 17px;
    }
    .auto-style3 {
        font-size: 20px;
    }
    </style>

    <form id="form1" runat="server">
        <center>
    <div>
    
        <asp:Label ID="Lb1" runat="server" Text="Shops to be Approved ID" CssClass="auto-style3"></asp:Label>
        <br/>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="ShopId" DataValueField="ShopId" Height="83px" Width="275px" CssClass="auto-style2">
        </asp:CheckBoxList>
        <br />
        <br />
      &nbsp;&nbsp;  <asp:Button ID="B3" runat="server" Text="Shop Details" OnClick="B3_Click" CssClass="auto-style1" />
        <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Lb2" runat="server" Text="" Visible="false"></asp:Label>
        <br />
&nbsp;&nbsp;
        <asp:Button ID="B1" runat="server" Text="Approve" OnClick="B1_Click" CssClass="auto-style1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="B2" runat="server" Text="Delete" OnClick="B2_Click" CssClass="auto-style1" />
&nbsp;<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShopDBConnectionString %>" SelectCommand="SELECT [ShopId] FROM [shoptbl] WHERE ([Approved] = @Approved)">
            <SelectParameters>
                <asp:Parameter DefaultValue="False" Name="Approved" Type="Boolean" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />


    </div></center>
    </form>
</asp:Content>
