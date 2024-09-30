<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertPageMakeupType.aspx.cs" Inherits="Project_Lab.Views.InsertPageMakeupType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Insert Makeup Type</h1>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Makeup Type Name:  "></asp:Label>
                <asp:TextBox ID="nameTB" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="BackBtn" runat="server" Text="Back" OnClick="BackBtn_Click" />
            <asp:Button ID="InsertBtn" runat="server" Text="Insert" OnClick="InsertBtn_Click" />
            <asp:Label ID="ErrLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
