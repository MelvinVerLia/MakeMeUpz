<%@ Page Title="" Language="C#" MasterPageFile="~/Header/HeaderMaster.Master" AutoEventWireup="true" CodeBehind="HandleTransactionPage.aspx.cs" Inherits="Project_Lab.Views.HandleTransactionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
     <h1>Handle Transaction</h1>
 </div>
 <div class="HistoryPage">
     <asp:GridView ID="TransactionGV" runat="server" AutoGenerateColumns="False">
         <Columns>
             <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID" />
             <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID" />
             <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate" />
             <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
             <asp:TemplateField HeaderText="Handle">
                 <ItemTemplate>
                     <asp:Button ID="Handlebtn" CssClass="DetailButton" runat="server" Text="Handle" OnClick="Handlebtn_Click"/>
                 </ItemTemplate>
             </asp:TemplateField>
         </Columns>


     </asp:GridView>
 </div>
</asp:Content>
