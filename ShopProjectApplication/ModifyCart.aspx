<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyCart.aspx.cs" Inherits="ShopProjectApplication.ModifyCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 445px;
            height: 300px;
        }
        .auto-style2 {
            height: 124px;
            background-color: #BDD9FF;
        }
        .auto-style3 {
            background-color: #BDD9FF;
        }
    </style>
</head>
<body>
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
        <center>
        <table border="1" class="auto-style1">
        <tr>
            <td class="auto-style3">Product Name <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
        </td>

        </tr>
            <tr>
                <td class="auto-style3">
                Shop Name <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="37px" Width="160px"></asp:DropDownList>
                </td>

            </tr>
            <tr>
                <td class="auto-style3" >
                    Price&nbsp;<asp:Label ID="Label3" runat="server" Text=" "></asp:Label>
                </td>
            </tr></table>
           
                    <asp:Button ID="Button1" runat="server" Text="Change" Height="53px" Width="142px" OnClick="Button1_Click"></asp:Button>
               
            
            </center>
        <p>
            &nbsp;</p>
    <div>
    
    </div>
    </form>
</body>
</html>
