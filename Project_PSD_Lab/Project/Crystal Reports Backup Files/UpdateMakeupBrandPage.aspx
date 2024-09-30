<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMakeupBrandPage.aspx.cs" Inherits="Project_Lab.Views.UpdateMakeupBrandPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Insert Makeup Brand</h1>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Makeup Brand Name:  "></asp:Label>
                <asp:TextBox ID="nameTB" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Brand Rating:  "></asp:Label>
                <asp:TextBox ID="RatingTB" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="BackBtn" runat="server" Text="Back" OnClick="BackBtn_Click" />
            <asp:Button ID="UpdateBtn" runat="server" Text="Insert" OnClick="UpdateBtn_Click" />
            <asp:Label ID="ErrLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
