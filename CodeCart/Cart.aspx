<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Site1.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="CodeCart.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h1>Carrello:</h1>
        <div id="CartContainer" runat="server">
       </div>
    <asp:Button ID="ClearCart" runat="server" CssClass="btn btn-danger my-3" Text="Clear Cart" OnClick="ClearAll"/>
</asp:Content>
