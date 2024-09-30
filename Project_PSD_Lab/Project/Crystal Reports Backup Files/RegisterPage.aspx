<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Project_Lab.Views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Register</h1>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username  "></asp:Label>
            <asp:TextBox ID="usernameTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Email  "></asp:Label>
            <asp:TextBox ID="emailTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Gender  "></asp:Label>
            <asp:RadioButton ID="MaleRadio" runat="server" Text="Male" GroupName="Gender"/>
            <asp:RadioButton ID="FemaleRadio" runat="server" Text="Female" GroupName="Gender"/>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Password  "></asp:Label>
            <asp:TextBox ID="passwordTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Confirm Password  "></asp:Label>
            <asp:TextBox ID="confPassTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Date of Birth  "></asp:Label>
            <asp:Calendar ID="DOBTB" runat="server"></asp:Calendar>
            <br />
        </div>
        <asp:Button ID="Register" runat="server" Text="Register" OnClick="Register_Click"/>
        <asp:Label ID="ErrorLabel" runat="server" Text="" ForeColor="Red"></asp:Label>
        <div>
            <asp:LinkButton ID="loginbtn" runat="server" Font-Size="X-Small" OnClick="loginbtn_Click">already have an account? click here</asp:LinkButton>
        </div>
    </form>
</body>
</html>
