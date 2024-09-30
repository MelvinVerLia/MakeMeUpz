<%@ Page Title="" Language="C#" MasterPageFile="~/Header/HeaderMaster.Master" AutoEventWireup="true" CodeBehind="ManageMakeupPage.aspx.cs" Inherits="Project_Lab.Views.ManageMakeupPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Manage Makeup</h1>
    <div class="ManageMakeup">
        <div class="ManageGV">
            <div class="ManageLabel">
                <asp:Label ID="Label1" runat="server" Text="Make Up Data"></asp:Label>
            </div>
            <asp:GridView ID="MakeUpGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="MakeUpGV_RowDeleting" OnRowEditing="MakeUpGV_RowEditing">
                <Columns>
                    <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID" />

                    <asp:BoundField DataField="MakeupName" HeaderText="MakeupName" SortExpression="MakeupName" />
                    <asp:BoundField DataField="MakeupPrice" HeaderText="MakeupPrice" SortExpression="MakeupPrice" />
                    <asp:BoundField DataField="MakeupWeight" HeaderText="MakeupWeight" SortExpression="MakeupWeight" />
                    <asp:BoundField DataField="MakeupTypeID" HeaderText="MakeupType" SortExpression="MakeupTypeID" />
                    <asp:BoundField DataField="MakeupBrandID" HeaderText="MakeUpBrand" SortExpression="MakeupBrandID" />

                    <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />

                </Columns>
            </asp:GridView>
            <asp:Button ID="MakeupInsertBtn" CssClass="ManageButton" runat="server" Text="Insert Makeup" OnClick="MakeupInsertBtn_Click" />

        </div>
        <br />
        <div class="ManageGV">
            <div class="ManageLabel">
                <asp:Label ID="Label2" runat="server" Text="Make Up Type Data"></asp:Label>
            </div>

            <asp:GridView ID="MakeUpTypeGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="MakeUpTypeGV_RowDeleting" OnRowEditing="MakeUpTypeGV_RowEditing">
                <Columns>
                    <asp:BoundField DataField="MakeupTypeID" HeaderText="TypeID" SortExpression="MakeupTypeID" />
                    <asp:BoundField DataField="MakeupTypeName" HeaderText="Type Name" SortExpression="MakeupTypeName" />
                    <asp:CommandField ButtonType="Button"  HeaderText="Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
                </Columns>
            </asp:GridView>

            <asp:Button ID="TypeInsertBtn" runat="server" CssClass="ManageButton" Text="Insert Makeup Type" OnClick="TypeInsertBtn_Click" />

        </div>
        <br />
        <div class="ManageGV">
            <div class="ManageLabel">
                <asp:Label ID="Label3" runat="server" Text="Make Up Brand Data"></asp:Label>
            </div>

            <asp:GridView ID="MakeUpBrandGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="MakeUpBrandGV_RowDeleting" OnRowEditing="MakeUpBrandGV_RowEditing">
                <Columns>
                    <asp:BoundField DataField="MakeupBrandID" HeaderText="BrandID" SortExpression="MakeupBrandID" />
                    <asp:BoundField DataField="MakeupBrandName" HeaderText="Brand Name" SortExpression="MakeupBrandName" />
                    <asp:BoundField DataField="MakeupBrandRating" HeaderText="Brand Rating" SortExpression="MakeupBrandRating" />
                    <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
                </Columns>
            </asp:GridView>

            <asp:Button ID="BrandInsertBtn" runat="server" CssClass="ManageButton" Text="Insert Makeup Brand" OnClick="BrandInsertBtn_Click" />


        </div>
    </div>

</asp:Content>
