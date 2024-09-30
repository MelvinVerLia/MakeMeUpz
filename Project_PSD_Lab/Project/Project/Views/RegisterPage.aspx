<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Project_Lab.Views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="~/Css/Styling2.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="registerContainer">
            <h1>Register</h1>
            <div class="inputContainer">
                <div class="Username">
                    <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                    <asp:TextBox ID="usernameTB" runat="server"></asp:TextBox>
                </div>
                <div class="Email">
                    <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="emailTB" runat="server"></asp:TextBox>
                </div>
                <div class="Gender">
                    <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
                    <asp:RadioButton ID="MaleRadio" runat="server" Text="Male" GroupName="Gender" />
                    <asp:RadioButton ID="FemaleRadio" runat="server" Text="Female" GroupName="Gender" />
                </div>
                <div class="Password">
                    <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
                    <asp:TextBox ID="passwordTB" runat="server"></asp:TextBox>
                </div>
                <div class="ConfPass">
                    <asp:Label ID="Label5" runat="server" Text="Confirm Password"></asp:Label>
                    <asp:TextBox ID="confPassTB" runat="server"></asp:TextBox>
                </div>
            </div>
            <div>
                <asp:Label ID="Label6" runat="server" Text="Date of Birth"></asp:Label>
                <asp:Calendar ID="DOBTB" CssClass="Calendar" runat="server"></asp:Calendar>
            </div>
            <asp:Label ID="ErrorLabel" Font-Size="Small" runat="server" Text="" ForeColor="Red"></asp:Label>
            <div class="ButtonContainer">
                <asp:Button ID="Register" CssClass="LoginButton" runat="server" Text="Register" OnClick="Register_Click" />

                <asp:LinkButton ID="loginbtn" runat="server" CssClass="RegHover" Font-Size="Small" OnClick="loginbtn_Click">already have an account? click here</asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
