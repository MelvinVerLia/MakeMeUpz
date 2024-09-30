﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMakeupPage.aspx.cs" Inherits="Project_Lab.Views.UpdateMakeupPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Update Makeup</h1>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Makeup Name:  "></asp:Label>
                <asp:TextBox ID="nameTB" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Makeup Price:  "></asp:Label>
                <asp:TextBox ID="priceTB" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label3" runat="server" Text="Makeup Weight:  "></asp:Label>
                <asp:TextBox ID="weightTB" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label4" runat="server" Text="Makeup Type:  "></asp:Label>
                <asp:DropDownList ID="TypeDD" runat="server"></asp:DropDownList>
            </div>
            <div>
                <asp:Label ID="Label5" runat="server" Text="Makeup Brand:  "></asp:Label>
                <asp:DropDownList ID="BrandDD" runat="server"></asp:DropDownList>
            </div>
            <asp:Button ID="BackBtn" runat="server" Text="Back" OnClick="BackBtn_Click"/>
            <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
            <asp:Label ID="ErrLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>