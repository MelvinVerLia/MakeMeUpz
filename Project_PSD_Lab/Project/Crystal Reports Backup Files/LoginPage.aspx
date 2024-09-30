<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Project_Lab.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Login Makeup</h1>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username  "></asp:Label>
            <asp:TextBox ID="UsernameTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password  "></asp:Label>
            <asp:TextBox ID="PasswordTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="RememberCheck" runat="server" Text="remember me"/>
        </div>
        <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click"/>
        <asp:Label ID="ErrorLabel" runat="server" Text="" ForeColor="Red"></asp:Label>
        <div>
            <asp:LinkButton ID="registerbtn" runat="server" Font-Size="X-Small" OnClick="registerbtn_Click">click here to make an account</asp:LinkButton>
        </div>
    </form>
</body>
</html>
