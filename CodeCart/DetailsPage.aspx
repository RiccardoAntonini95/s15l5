<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Site1.Master" AutoEventWireup="true" CodeBehind="DetailsPage.aspx.cs" Inherits="CodeCart.DetailsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row d-flex align-items-center">
        <div class="col d-flex justify-content-center">
            <div class="card" style="width : 18rem" runat="server">
                <img ID="DetailPic" src="gggs" class="card-img-top" runat="server">
                <div class="card-body">
                    <h5 ID="DetailName" class="card-title" runat="server"></h5>
                    <p ID="DetailDescription" class="card-text" runat="server"></p>
                    <p ID="DetailPrice" class="card-text" runat="server"></p>
                    <a href="Home.aspx" class="btn btn-primary">Torna alla home</a>
                    <asp:Button ID="ButtonAdd" CssClass="btn btn-success" runat="server" Text="Aggiungi al carrello" OnClick="AddToCart"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
