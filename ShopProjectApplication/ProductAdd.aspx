<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="ProductAdd.aspx.cs" Inherits="ShopProjectApplication.ProductAdd" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
    <div style="height: 698px">
    
        <br />
&nbsp;&nbsp;&nbsp; Add Products<br />
&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Tb1" runat="server" Visible="false" Enabled="false"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp; Product ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Tb2" runat="server"></asp:TextBox>
     
        <asp:Label ID="Lb5" runat="server" Text="Enter Product ID" Visible="false"></asp:Label>
     
        <br />
        <br />
&nbsp;&nbsp;&nbsp; Product Name&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Tb3" runat="server"></asp:TextBox>
        <asp:Label ID="Lb6" runat="server" Text="Enter Product Name" Visible="false"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp; Product Category&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="dd1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Food-Item</asp:ListItem>
            <asp:ListItem>Clothes</asp:ListItem>
            <asp:ListItem>Shoes</asp:ListItem>
            <asp:ListItem>Bags</asp:ListItem>
            <asp:ListItem>Stationary</asp:ListItem>
            <asp:ListItem>Paintings</asp:ListItem>
            <asp:ListItem>Others</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Lb1" runat="server" Text="Size" Visible="false"></asp:Label>&nbsp;&nbsp;
        <asp:DropDownList ID="dd2" runat="server" AutoPostBack="True" Visible="False">
        </asp:DropDownList>
        <br />
        &nbsp;<br />
&nbsp;&nbsp;&nbsp; Price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Tb4" runat="server" OnTextChanged="Tb4_TextChanged" AutoPostBack="true"></asp:TextBox>

        <asp:Label ID="Lb2" runat="server" Text="Enter Price>=0" Visible="False"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp; Quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Tb5" runat="server" OnTextChanged="Tb5_TextChanged" AutoPostBack="true"></asp:TextBox>
         <asp:Label ID="Lb3" runat="server" Text="Enter Quantity>=0" Visible="False"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp; Product Image&nbsp;&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Lb8" runat="server" Text="" Visible="false" Enabled="false"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirm Product Upload" Width="261px"/>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Add Other Size" Visible="false" Enabled="false"/>
&nbsp;<asp:Label ID="Lb4" runat="server" Text="" Visible="false"></asp:Label>
        <br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add Another Product" Width="261px" Enabled="false" Visible="false"/>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Lb7" runat="server" Text="" Enabled="false" Visible="false"></asp:Label>
        </div>
    </form>
</asp:Content>
