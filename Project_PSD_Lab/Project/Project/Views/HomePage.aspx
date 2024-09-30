<%@ Page Title="" Language="C#" MasterPageFile="~/Header/HeaderMaster.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Project_Lab.Views.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="title">
        <h1>Welcome to MakeMeUpzz</h1>
    </div>
    <div class="HomeContent">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Username: "></asp:Label>
            <asp:Label ID="UsernameLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Role: "></asp:Label>
            <asp:Label ID="RoleLbl" runat="server" Text=""></asp:Label>
        </div>
    </div>
    <br />
    <div class="HomeGrid">
        <asp:GridView ID="UserGV" runat="server" AutoGenerateColumns="False" Visible="false">
            <Columns>
                <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID" />
                <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                <asp:BoundField DataField="UserEmail" HeaderText="UserEmail" SortExpression="UserEmail" />
                <asp:BoundField DataField="UserDOB" HeaderText="UserDOB" SortExpression="UserDOB" />
                <asp:BoundField DataField="UserGender" HeaderText="UserGender" SortExpression="UserGender" />
                <asp:BoundField DataField="UserRole" HeaderText="UserRole" SortExpression="UserRole" />
                <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" SortExpression="UserPassword" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
