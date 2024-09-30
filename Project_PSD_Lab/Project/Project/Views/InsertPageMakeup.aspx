<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertPageMakeup.aspx.cs" Inherits="Project_Lab.Views.InsertPageMakeup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/Css/Styling2.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="InsertContainer">
            <h1>Insert Makeup</h1>
            <div class="InputContainer">
                <div class="Name">
                    <asp:Label ID="Label1" runat="server" Text="Makeup Name:  "></asp:Label>
                    <asp:TextBox ID="nameTB" runat="server"></asp:TextBox>
                </div>
                <div class="Price">
                    <asp:Label ID="Label2" runat="server" Text="Makeup Price:  "></asp:Label>
                    <asp:TextBox ID="priceTB" runat="server"></asp:TextBox>
                </div>
                <div class="Weight">
                    <asp:Label ID="Label3" runat="server" Text="Makeup Weight:  "></asp:Label>
                    <asp:TextBox ID="weightTB" runat="server"></asp:TextBox>
                </div>
                <div class="Type">
                    <asp:Label ID="Label4" runat="server" Text="Makeup Type:  "></asp:Label>
                    <asp:DropDownList ID="TypeDD" runat="server"></asp:DropDownList>
                </div>
                <div class="Brand">
                    <asp:Label ID="Label5" runat="server" Text="Makeup Brand:  "></asp:Label>
                    <asp:DropDownList ID="BrandDD" runat="server"></asp:DropDownList>
                </div>
            </div>
            <div class="ErrorLabel">
                <asp:Label ID="ErrLbl" Font-Size="Small" runat="server" Text="" ForeColor="Red"></asp:Label>
            </div>
            <div class="ButtonContainer2">
                <asp:Button ID="BackBtb" CssClass="BackButton" runat="server" Text="Back" OnClick="BackBtb_Click" />
                <asp:Button ID="InsertBtn" CssClass="InsertButton" runat="server" Text="Insert" OnClick="InsertBtn_Click" />
            </div>

        </div>

    </form>
</body>
</html>
