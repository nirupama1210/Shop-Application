<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customerregister.aspx.cs" Inherits="ShopProjectApplication.Customer_register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">



<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
            font-size: xx-large;
            color: #CC0099;
            text-decoration: underline;
            background-color: #FFFFFF;
        }
        .style3
        {
            font-size: xx-large;
            color: #000099;
            text-decoration: underline;
            background-color: #FFFFFF;
        }
        .style4
        {
            font-size: xx-large;
            color: #333399;
            text-decoration: underline;
            background-color: #FFFFFF;
        }
        .style5
        {
            font-size: xx-large;
            color: #0000FF;
            text-decoration: underline;
            background-color: #FFFFFF;
        }
        .style6
        {
            font-size: xx-large;
            color: #6600FF;
            text-decoration: underline;
            background-color: #FFFFFF;
        }
        .style8
        {
            font-size: xx-large;
            color: #CC00FF;
            text-decoration: underline;
            background-color: #FFFFFF;
        }
        .style9
        {
            width: 100%;
        }
        .style10
        {
            width: 362px;
        }
        .style11
        {
            width: 362px;
            height: 26px;
        }
        .style12
        {
            height: 26px;
        }
        .style13
        {
            width: 560px;
            margin-left: 200px;
        }
        .style14
        {
            height: 26px;
            width: 560px;
        }
        .auto-style1 {
            width: 289px;
        }
        .auto-style2 {
            height: 26px;
            width: 289px;
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
     <div class="container">  
    
        <br />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong><span class="style2">RE</span><span class="style3">G</span><span 
            class="style8">IS</span><span class="style4">TER</span><span class="style5"> 
        PA</span><span class="style6">GE</span></strong><br />
        <br />
        <br />
        <table class="style9">
            <tr>
                <td class="style10">
                    USERNAME</td>
                <td class="style13">
                    <asp:TextBox ID="username" runat="server" Height="40px" Width="549px"></asp:TextBox>
                    <br />
                    <br />
                </td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="username" ErrorMessage="Enter username" ForeColor="#FF33CC"></asp:RequiredFieldValidator>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style10">
                    EMAIL ID<br />
                </td>
                <td class="style13">
                    <asp:TextBox ID="emailid" runat="server" Height="41px" TextMode="Email" 
                        Width="551px"></asp:TextBox>
                    <br />
                    <br />
                </td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="emailid" ErrorMessage="Enter Email ID" 
                        ForeColor="#FF33CC"></asp:RequiredFieldValidator>
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    PHONE No.<br />
                </td>
                <td class="style14">
                    <asp:TextBox ID="phnno" runat="server" Height="43px" Width="549px"></asp:TextBox>
                    <br />
                    <br />
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="phnno" ErrorMessage="Enter Phone Number" ForeColor="#FF33CC"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style10">
                    PASSWORD<br />
                </td>
                <td class="style13">
                    
                    <div class="input-group">  
                        <asp:TextBox ID="password" TextMode="Password" runat="server" 
                            CssClass="form-control" Height="41px" Width="343px"></asp:TextBox>  
                        <div class="input-group-append">  
                            <button id="show_password" class="btn btn-primary" type="button">  
                                <span class="fa fa-eye-slash icon"></span>  
                            </button>  
                        </div>  
                    </div>
                    <br />
                </td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="password" ErrorMessage="plz Enter your password" 
                        ForeColor="#FF33CC"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="password" 
                        
                        ForeColor="#FF33CC" 
                       ValidationExpression="^[a-zA-Z0-9'@&#.\s]{7,10}$" ErrorMessage="Set Password Minimum length 7 and Maximum length 10. Characters allowed – a - z  A - Z 0-9 ’@ & #"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style10">
                    RETYPE PASSWORD<br />
                </td>
                <td class="style13">
                    <asp:TextBox ID="retypepass" runat="server" Height="41px" TextMode="Password" 
                        Width="557px"></asp:TextBox>
                    <br />
                </td>
                <td style="margin-left: 80px" class="auto-style1">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="retypepass" ErrorMessage="Retype your password" 
                        ForeColor="#FF33CC"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="password" ControlToValidate="retypepass" 
                        ErrorMessage="Both password must be same" ForeColor="#FF33CC"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style10">
                    &nbsp;</td>
                <td class="style13">
                    <br />
                    <asp:Button ID="Button1" runat="server" Height="51px" Text="REGISTER" 
                        Width="332px" OnClick="Button1_Click" />
                    <br />
                </td>
                <td class="auto-style1">
               <asp:HyperLink ID="HyperLink1" runat="server" 
                        NavigateUrl="~/Customerlogin.aspx">Already have an Account ? Login Now</asp:HyperLink></td>
            </tr>
        </table>

    </div>
    </form>
</body>
</html>
