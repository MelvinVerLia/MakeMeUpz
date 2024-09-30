<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Project_Lab.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="~/Css/Styling2.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="loginContainer">
            <h1>Login</h1>
            <div class="inputContainer">
                <div class="Username">
                    <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                    <asp:TextBox ID="UsernameTB" runat="server"></asp:TextBox>
                </div>
                <div class="Password">
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    <asp:TextBox ID="PasswordTB" runat="server"></asp:TextBox>
                </div>
                <div class="RememberCheck">
                    <asp:CheckBox ID="RememberCheck" runat="server" Text="remember me" />
                </div>
            </div>
            <asp:Label ID="ErrorLabel" Font-Size="Small" runat="server" Text="" ForeColor="Red"></asp:Label>
            <div class="ButtonContainer">
                <asp:Button ID="Login" CssClass="LoginButton" runat="server" Text="Login" OnClick="Login_Click" />

                <asp:LinkButton ID="registerbtn" runat="server" CssClass="RegHover" Font-Size="Small" OnClick="registerbtn_Click">click here to make an account</asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
