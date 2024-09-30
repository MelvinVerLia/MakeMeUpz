<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertPageMakeupType.aspx.cs" Inherits="Project_Lab.Views.InsertPageMakeupType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/Css/Styling2.css" />

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="InsertContainer">
            <h1>Insert Makeup Type</h1>
            <div class="InputContainer">
                <div class="Name">
                    <asp:Label ID="Label1" runat="server" Text="Makeup Type Name:  "></asp:Label>
                    <asp:TextBox ID="nameTB" runat="server"></asp:TextBox>
                </div>
            </div>
            <asp:Label ID="ErrLbl" Font-Size="Small" runat="server" Text="" ForeColor="Red"></asp:Label>
            <div class="ButtonContainer2">
                <asp:Button ID="BackBtn" CssClass="BackButton" runat="server" Text="Back" OnClick="BackBtn_Click" />
                <asp:Button ID="InsertBtn" CssClass="InsertButton" runat="server" Text="Insert" OnClick="InsertBtn_Click" />
            </div>
        </div>
    </form>
</body>
</html>
