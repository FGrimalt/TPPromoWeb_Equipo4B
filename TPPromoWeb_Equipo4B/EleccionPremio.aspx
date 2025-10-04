<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagePromo.Master" AutoEventWireup="true" CodeBehind="EleccionPremio.aspx.cs" Inherits="TPPromoWeb_Equipo4B.EleccionPremio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <asp:Label ID="lblSeleccionPremio" runat="server" Text="Elegí tu premio: " CssClass="h3 mb-4"></asp:Label>
        <div class="row" id="divCards" runat="server">
            <asp:PlaceHolder ID="phPremios" runat="server"></asp:PlaceHolder>
        </div>
    </div>
</asp:Content>
