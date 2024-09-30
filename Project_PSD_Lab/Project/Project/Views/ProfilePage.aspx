<%@ Page Title="" Language="C#" MasterPageFile="~/Header/HeaderMaster.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="Project_Lab.Views.ProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Profile</h1>
    <div class="ProfileContainer">
        <div class="UpdateProfileContainer">
            <h3>Update Profile</h3>
            <div class="Username">
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                <asp:TextBox ID="nameTB" runat="server"></asp:TextBox>
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
            <div>
                <asp:Label ID="Label6" runat="server" Text="Date of Birth = "></asp:Label>
                <asp:Label ID="DOBLbl" runat="server" Text=""></asp:Label>
                <asp:Calendar ID="DOBTB" CssClass="Calendar" runat="server"></asp:Calendar>
            </div>
            <asp:Label ID="ErrorLabelProfile" runat="server" Text="" ForeColor="Red"></asp:Label>
            <div class="ButtonContainer">
                <asp:Button ID="ProfileBtn" runat="server" CssClass="UpdateButton1" Text="Update Profile" OnClick="ProfileBtn_Click" />

            </div>
        </div>
        <div class="UpdatePassContainer">
            <h3>Update Password</h3>
            <div class="OldPass">
                <asp:Label ID="Label4" runat="server" Text="Old Password"></asp:Label>
                <asp:TextBox ID="oldPassTB" runat="server"></asp:TextBox>
            </div>
            <div class="NewPass">
                <asp:Label ID="Label5" runat="server" Text="New Password"></asp:Label>
                <asp:TextBox ID="newPassTB" runat="server"></asp:TextBox>
            </div>
            <asp:Label ID="ErrorLabelPassword" Font-Size="Small" runat="server" Text="" ForeColor="Red"></asp:Label>
            <div class="ButtonContainer">
                <asp:Button ID="PassBtn" CssClass="UpdateButton2" runat="server" Text="Update Password" OnClick="PassBtn_Click" />

            </div>
        </div>
    </div>



</asp:Content>
