<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="ProductDel.aspx.cs" Inherits="ShopProjectApplication.ProductDel" %>

<asp:Content runat="server" ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" >
    <form id="form1" runat="server">
    <div><br /><br />
        <asp:TextBox ID="Tb1" runat="server" Visible="false" Enabled="false"></asp:TextBox><br />
        Filter By <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem> </asp:ListItem>
            <asp:ListItem>By Category</asp:ListItem>
            <asp:ListItem>By Product ID</asp:ListItem>
            <asp:ListItem>By Product Name</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        &nbsp; &nbsp; &nbsp;<asp:DropDownList ID="Ddl2" runat="server" DataSourceID="SqlDataSource1" DataTextField="Category" DataValueField="Category" Visible="false" Enabled="false" AutoPostBack="True" OnSelectedIndexChanged="Ddl2_SelectedIndexChanged">
        </asp:DropDownList>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShopDBConnectionString %>" SelectCommand="SELECT DISTINCT [Category] FROM [prodtbl] WHERE ([ShopID] = @ShopID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="Tb1" Name="ShopID" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
       
        <asp:Label ID="Lb1" runat="server" Visible="false" Enabled="false"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="Ddl3" runat="server" Visible="false" Enabled="false" OnSelectedIndexChanged="Ddl3_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Lb2" runat="server" Visible="false" Enabled="false"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="Ddl4" runat="server" Visible="false" Enabled="false" AutoPostBack="True" OnSelectedIndexChanged="Ddl4_SelectedIndexChanged">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Lb3" runat="server" Text="Size" Visible="false" Enabled="false"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:DropDownList ID="Ddl5" runat="server" Visible="false" Enabled="false">
        </asp:DropDownList>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete Product" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Lb4" runat="server" Text="" Visible="false" Enabled="false"></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    </div>
    </form>
    </asp:Content>

