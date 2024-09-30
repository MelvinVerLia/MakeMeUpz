<%@ Page Title="" Language="C#" MasterPageFile="~/Header/HeaderMaster.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="Project.Views.TransactionDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div> <h1>Transaction Detail</h1></div>
 <div>
     <asp:GridView ID="TransactionGV" runat="server" AutoGenerateColumns="False">
         <Columns>
             <asp:BoundField DataField="TransactionId" HeaderText="TransactionId" SortExpression="TransactionId" />
             <asp:BoundField DataField="Makeup.MakeupName" HeaderText="MakeupName" SortExpression="Makeup.MakeupName" />
             <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
         </Columns>
     </asp:GridView>
 </div>
</asp:Content>
