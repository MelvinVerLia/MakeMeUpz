<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMakeupBrandPage.aspx.cs" Inherits="Project_Lab.Views.UpdateMakeupBrandPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/Css/Styling2.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="InsertContainer">
            <h1>Insert Makeup Brand</h1>
            <div class="InputContainer">
                <div class="Name">
                    <asp:Label ID="Label1" runat="server" Text="Makeup Brand Name:  "></asp:Label>
                    <asp:TextBox ID="nameTB" runat="server"></asp:TextBox>
                </div>
                <div class="Brand">
                    <asp:Label ID="Label2" runat="server" Text="Brand Rating:  "></asp:Label>
                    <asp:TextBox ID="RatingTB" runat="server"></asp:TextBox>
                </div>
            </div>
            <asp:Label ID="ErrLbl" Font-Size="Small" runat="server" Text="" ForeColor="Red"></asp:Label>
            <div class="ButtonContainer2">
                <asp:Button ID="BackBtn" CssClass="BackButton" runat="server" Text="Back" OnClick="BackBtn_Click" />
                <asp:Button ID="UpdateBtn" runat="server" CssClass="InsertButton" Text="Insert" OnClick="UpdateBtn_Click" />
            </div>
        </div>
    </form>
</body>
</html>
