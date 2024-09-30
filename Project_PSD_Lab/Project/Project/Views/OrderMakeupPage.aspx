<%@ Page Title="" Language="C#" MasterPageFile="~/Header/HeaderMaster.Master" AutoEventWireup="true" CodeBehind="OrderMakeupPage.aspx.cs" Inherits="Project_Lab.Views.OrderMakeupPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Order Makeup</h1>
    </div>
    <div class="OrderMakeup">
        <div class="GV1">
            <asp:GridView ID="MakeUpGV" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID" />
                    <asp:BoundField DataField="MakeupName" HeaderText="MakeupName" SortExpression="MakeupName" />
                    <asp:BoundField DataField="MakeupPrice" HeaderText="MakeupPrice" SortExpression="MakeupPrice" />
                    <asp:BoundField DataField="MakeupWeight" HeaderText="MakeupWeight" SortExpression="MakeupWeight" />
                    <asp:BoundField DataField="MakeupType.MakeUpTypeName" HeaderText="MakeupType" SortExpression="MakeupType.MakeUpTypeName" />
                    <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="MakeUpBrand" SortExpression="MakeupBrand.MakeupBrandName" />
                    <asp:TemplateField HeaderText="Quantity">
                        <ItemTemplate>
                            <asp:TextBox ID="QuantityTB" runat="server" Text="0" Width="95%" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Order">
                        <ItemTemplate>
                            <asp:Button ID="OrderBtn" CssClass="DetailButton" runat="server" Text="Order" OnClick="OrderButton_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <div>
            <asp:Label ID="SuccessLbl" runat="server" Text="" ForeColor="Green"></asp:Label>
        </div>
        <br />
        <div class="GV2">
            <asp:GridView ID="CartGV" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="CartID" HeaderText="CartID" SortExpression="CartID" />
                    <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID" />
                    <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                </Columns>
            </asp:GridView>
        </div>
        <div>
            <asp:Label ID="SuccessLbl2" runat="server" Text="" ForeColor="Green"></asp:Label>
        </div>
    </div>

    <br />
    <div class="OrderButton">
        <asp:Button ID="ClearCartButton" runat="server" CssClass="ClearButton" Text="Clear Cart" OnClick="ClearCartButton_Click" />
        <asp:Button ID="CheckoutButton" runat="server" Text="Checkout" CssClass="CheckoutButton" OnClick="CheckoutButton_Click" />
    </div>

</asp:Content>
