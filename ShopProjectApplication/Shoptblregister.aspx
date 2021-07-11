<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shoptblregister.aspx.cs" Inherits="ShopProjectApplication.Shoptbl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-size: xx-large;
        }
        .style2
        {
            width: 76%;
            margin-left: 317px;
        }
        .style7
        {
            width: 382px;
            height: 49px;
        }
        .style19
        {
            width: 382px;
            height: 40px;
            text-align: right;
        }
        .style20
        {
            width: 430px;
            height: 40px;
        }
        .style21
        {
            width: 461px;
            height: 40px;
        }
        .style23
        {
            width: 382px;
            height: 52px;
            text-align: right;
        }
        .style24
        {
            width: 430px;
            height: 52px;
        }
        .style25
        {
            width: 461px;
            height: 52px;
        }
        .style26
        {
            width: 375px;
            height: 40px;
        }
        .style27
        {
            width: 103px;
            height: 40px;
        }
        .style32
        {
            width: 382px;
            height: 167px;
            text-align: right;
        }
        .style33
        {
            width: 430px;
            height: 167px;
        }
        .style34
        {
            width: 461px;
            height: 167px;
        }
        .style35
        {
            width: 430px;
            height: 49px;
        }
        .style36
        {
            width: 461px;
            height: 49px;
        }
        .style37
        {
            width: 382px;
            height: 51px;
            text-align: right;
        }
        .style38
        {
            width: 430px;
            height: 51px;
        }
        .style39
        {
            width: 461px;
            height: 51px;
        }
        .style40
        {
            width: 382px;
            height: 49px;
            text-align: right;
        }
        .style41
        {
            width: 382px;
            height: 42px;
            text-align: right;
        }
        .style42
        {
            width: 430px;
            height: 42px;
        }
        .style43
        {
            width: 461px;
            height: 42px;
        }
        .auto-style1 {
            background-color: #99CCFF;
        }
        .auto-style2 {
            background-color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <span class="style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        REGISTER
        <br />
        <br />
        <br />
        </span>

        <table class="style2">
            <tr>
                <td class="style7" style="text-align: right">
                    SHOP_ID</td>
                <td class="style35" colspan="2">
                    <asp:TextBox ID="shopid" runat="server" Width="256px"></asp:TextBox>
                &nbsp;<asp:Label ID="Lb1" runat="server" Text="" Visible="false" Enabled="false"></asp:Label>
                </td>
                <td class="style36">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Enter Your ShopId" ControlToValidate="shopid" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style37">
                    SHOP_NAME</td>
                <td class="style38" colspan="2">
                    <asp:TextBox ID="shopname" runat="server" Width="251px"></asp:TextBox>
                </td>
                <td class="style39">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ErrorMessage="Enter ShopName" ControlToValidate="shopname" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style19">
                    PASSWORD</td>
                <td class="style20" colspan="2">
                    <asp:TextBox ID="password" runat="server" Width="251px"></asp:TextBox>
                </td>
                <td class="style21">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                       ValidationExpression="^[a-zA-Z0-9'@&#.\s]{7,10}$"  ControlToValidate="password" ErrorMessage="Set Password Minimum length 7 and Maximum length 10. Characters allowed – a - z  A - Z 0-9 ’@ & #" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style23">
                    PHONE_NUMBER</td>
                <td class="style24" colspan="2">
                    <asp:TextBox ID="phnno" runat="server" Width="248px"></asp:TextBox>
                    <asp:Label ID="Lb3" runat="server" Text="" Visible="false" Enabled="false"></asp:Label>
                </td>
                <td class="style25">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="phnno" ErrorMessage="Enter Phone Number" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style19" rowspan="5">
                    ADDRESS</td>
                <td class="style27">
                    Line 1</td>
                <td class="style26">
                    <asp:TextBox ID="line1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="line1" ErrorMessage="Enter your Shop No." 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="style21" rowspan="5">
                </td>
            </tr>
            <tr>
                <td class="style27">
                    Area</td>
                <td class="style20">
                    <asp:TextBox ID="area" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="area" ErrorMessage="Enter your area" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style27">
                    City</td>
                <td class="style20">
                    <asp:TextBox ID="city" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="city" ErrorMessage="Enter your city" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style27">
                    State</td>
                <td class="style20">
                    <asp:TextBox ID="state" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="state" ErrorMessage="Enter your State" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style27">
                    Pincode</td>
                <td class="style20">
                    <asp:TextBox ID="pincode" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="pincode" ErrorMessage="Enter pincode" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style40">
                    Email ID</td>
                <td class="style35" colspan="2">
                    <asp:TextBox ID="emailid" runat="server" Width="279px"></asp:TextBox>
                    <asp:Label ID="Lb2" runat="server" Text="" Visible="false"></asp:Label>
                </td>
                <td class="style36">
                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ControlToValidate="emailid" ErrorMessage="Enter your Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style32">
                </td>
                <td class="style33" colspan="2">
                    <asp:Button ID="Button1" runat="server" Height="58px" Text="Register" 
                        Width="512px" onclick="Button1_Click" CssClass="auto-style1" />
                </td>
                <td class="auto-style2">
               <asp:HyperLink ID="HyperLink1" runat="server" 
                        NavigateUrl="~/ShopLogin.aspx">Already have an Vendor Account ? Login Now</asp:HyperLink></td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
