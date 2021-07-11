<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShopLogin.aspx.cs" Inherits="ShopProjectApplication.ShopLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
         <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />  
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />  
<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script> 
    <script type="text/javascript">
    $(document).ready(function () {
        $('#show_password').hover(function show() {
            //Change the attribute to text  
            $('#pass').attr('type', 'text');
            $('.icon').removeClass('fa fa-eye-slash').addClass('fa fa-eye');
        },
            function () {
                //Change the attribute back to password  
                $('#pass').attr('type', 'pass');
                $('.icon').removeClass('fa fa-eye').addClass('fa fa-eye-slash');
            });
        //CheckBox Show Password  
        $('#ShowPassword').click(function () {
            $('#Password').attr('type', $(this).is(':checked') ? 'text' : 'password');
        });
    });  
    </script> 
    <style type="text/css">
        .style1
        {
            text-decoration: underline;
            font-size: xx-large;
        }
        .style2
        {
            text-align: center;
        }
        .style3
        {
            width: 75%;
            height: 159px;
        }
        .style4
        {
            text-align: right;
            width: 641px;
        }
        .style5
        {
            width: 641px;
        }
        .style6
        {
            width: 226px;
        }
        .style7
        {
            text-align: left;
        }
        .auto-style1 {
            background-color: #99CCFF;
        }
        .auto-style2 {
            display: block;
            font-size: 1rem;
            line-height: 1.5;
            color: #495057;
            background-color: #fff;
            background-clip: padding-box;
            border: 1px solid #ced4da;
            border-radius: .25rem;
            transition: border-color .15s ease-in-out,box-shadow .15s ease-in-out;
        }
        .auto-style3 {
            width: 302px;
        }
        .auto-style4 {
            text-align: right;
            width: 642px;
        }
        .auto-style5 {
            width: 642px;
        }
    </style>
    
</head>
<body>    <form id="form1" runat="server">
    <div class="style2">
    
        <br />
        <span class="style1"><strong>LOGIN PAGE</strong></span><br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <table class="style3">
            <tr>
                <td class="auto-style4">
                    Shop ID/Email</td>
                <td class="auto-style3">
                    <asp:TextBox ID="shopid" runat="server" Width="246px" Height="31px" CssClass="offset-sm-0"></asp:TextBox>
                </td>
                <td class="style7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="shopid" ErrorMessage="Enter ShopID/Email" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    Password</td>
                <td class="auto-style3">
                   <div class="input-group">  
                        <asp:TextBox ID="pass" TextMode="Password" runat="server" 
                            CssClass="offset-sm-0" Height="33px" Width="248px"></asp:TextBox>  
                        <div class="input-group-append">  
                            <button id="show_password" class="btn btn-primary" type="button">  
                                <span class="fa fa-eye-slash icon"></span>  
                            </button>  
                        </div>  
                    </div>
                </td>
                <td class="style7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="pass" ErrorMessage="Enter password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Login" runat="server" onclick="Login_Click" Text="Login" CssClass="auto-style1" Height="48px" Width="130px" />
                </td>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" 
                        NavigateUrl="~/Shoptblregister.aspx">Dont have an Account ?Register Now</asp:HyperLink>
                </td>
            </tr>
             <tr>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Home" runat="server" CausesValidation="false" Text="Home" CssClass="auto-style1" Height="48px" Width="130px" OnClick="Home_Click" />
                </td>
                <td>
                   
                </td>
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
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
