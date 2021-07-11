<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="ProductModify.aspx.cs" Inherits="ShopProjectApplication.ProductModify" %>
<asp:Content runat="server" ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" > 


    <form id="form1" runat="server">
    <div><br /><br />
    &nbsp;<asp:TextBox ID="Tb1" runat="server" Visible="false" Enabled="false"></asp:TextBox><br />
    
        <br />
      &nbsp;&nbsp;Search Product By &nbsp;&nbsp; <asp:DropDownList ID="Ddl1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Ddl1_SelectedIndexChanged" style="height: 25px">
            <asp:ListItem> </asp:ListItem>
            <asp:ListItem>Product ID</asp:ListItem>
            <asp:ListItem>Product Name</asp:ListItem>
        </asp:DropDownList>
    
        &nbsp;&nbsp;<asp:Label ID="Lb1" runat="server" Text="Product Names: " Enabled="false" Visible="false"></asp:Label>
&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="Ddl2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="ProdName" DataValueField="ProdName" OnSelectedIndexChanged="Ddl2_SelectedIndexChanged" Enabled="false" Visible="false">
        </asp:DropDownList>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShopDBConnectionString %>" SelectCommand="SELECT DISTINCT [ProdName] FROM [prodtbl] WHERE ([ShopID] = @ShopID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="Tb1" Name="ShopID" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
              &nbsp;&nbsp; 
        <asp:Label ID="Lb2" runat="server" Text="Product ID" Enabled="false" Visible="false"></asp:Label>
        &nbsp;&nbsp;  <asp:DropDownList ID="Ddl3" runat="server" OnSelectedIndexChanged="Ddl3_SelectedIndexChanged" Enabled="false" Visible="false" AutoPostBack="True">
        </asp:DropDownList>
    
        <br />
        <asp:Label ID="Lb3" runat="server" Text="Modify" Enabled="false" Visible="false"></asp:Label>
&nbsp;&nbsp;
        <asp:DropDownList ID="Ddl4" runat="server" Enabled="false" Visible="false" OnSelectedIndexChanged="Ddl4_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem>Product Name</asp:ListItem>
            <asp:ListItem>Category</asp:ListItem>
            <asp:ListItem>Price</asp:ListItem>
            <asp:ListItem>Quantity</asp:ListItem>
            <asp:ListItem>Product Image</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Lb4" runat="server" Text="" Enabled="false" Visible="false"></asp:Label>

        &nbsp;<asp:DropDownList ID="Ddl5" runat="server" Enabled="false" Visible="false" AutoPostBack="True" OnSelectedIndexChanged="Ddl5_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:TextBox ID="Tb2" runat="server"  Enabled="false" Visible="false"></asp:TextBox>

        &nbsp;&nbsp;<asp:Label ID="Lb7" runat="server" Text="" Visible="false" Enabled="false"></asp:Label>
        <br />
        &nbsp;<asp:Label ID="Lb5" runat="server" Text="Size" Enabled="false" Visible="false"></asp:Label>
&nbsp;<asp:DropDownList ID="Ddl6" runat="server" AutoPostBack="True"  Enabled="false" Visible="false" OnSelectedIndexChanged="Ddl6_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" Visible="false" Enabled="false"/>

        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Lb8" runat="server" Text="No Image File Chosen" Visible="false" Enabled="false"></asp:Label>

        <br />
        <br />
        <asp:Button ID="Bt1" runat="server" Text="Update Product" Visible="false" Enabled="false" OnClick="Bt1_Click"/>

        &nbsp;&nbsp;&nbsp;

        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Lb6" runat="server" Text="" Visible="false" Enabled="false"></asp:Label>
        <br />

        <br />
    
    </div>
    </form>
</asp:Content>
