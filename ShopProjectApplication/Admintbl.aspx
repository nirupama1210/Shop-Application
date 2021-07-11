<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admintbl.aspx.cs" Inherits="ShopProjectApplication.Admintbl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        .auto-style2 {
            background-color: #99CCFF;
        }
        .auto-style3 {
            text-align: left;
            width: 212px;
        }
        .auto-style4 {
            width: 212px;
        }
        .auto-style5 {
            display: block;
            font-size: 1rem;
            line-height: 1.5;
            color: #495057;
            background-color: #99CCFF;
            background-clip: padding-box;
            border: 1px solid #ced4da;
            border-radius: .25rem;
            transition: border-color .15s ease-in-out,box-shadow .15s ease-in-out;
        }
    </style>
      <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />  
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />  
<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>  
    <script type="text/javascript">
    $(document).ready(function () {
        $('#show_password').hover(function show() {
            //Change the attribute to text  
            $('#password').attr('type', 'text');
            $('.icon').removeClass('fa fa-eye-slash').addClass('fa fa-eye');
        },
            function () {
                //Change the attribute back to password  
                $('#password').attr('type', 'password');
                $('.icon').removeClass('fa fa-eye').addClass('fa fa-eye-slash');
            });
        //CheckBox Show Password  
        $('#ShowPassword').click(function () {
            $('#Password').attr('type', $(this).is(':checked') ? 'text' : 'password');
        });
    });  
    </script>  
</head>
<body>
    <form id="form1" runat="server">
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
                <td class="style4">
                    Username</td>
                <td class="style6">
                    <asp:TextBox ID="Username" runat="server" Width="211px" CssClass="offset-sm-0" Height="41px"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="Username" ErrorMessage="Enter your name" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Password</td>
                <td class="style6">
                    <div class="input-group">  
                        <asp:TextBox ID="password" TextMode="Password" runat="server" 
                            CssClass="auto-style1" Height="41px" Width="211px"></asp:TextBox>  
                        <div class="input-group-append">  
                            <button id="show_password" class="btn btn-primary" type="button">  
                                <span class="fa fa-eye-slash icon"></span>  
                            </button>  
                        </div>  
                    </div>
                </td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="password" ErrorMessage="Enter password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style6">
                    <asp:Button ID="login" runat="server" onclick="login_Click" Text="Login" CssClass="auto-style2" Height="39px" Width="104px" />
                </td>
               <td >
                    <asp:Button ID="Button2" runat="server" CausesValidation="false" Text="Home" CssClass="auto-style5" Height="39px" Width="104px" OnClick="Home_Click" />
                   
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
