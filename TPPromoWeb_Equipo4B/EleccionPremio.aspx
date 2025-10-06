<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagePromo.Master" AutoEventWireup="true" CodeBehind="EleccionPremio.aspx.cs" Inherits="TPPromoWeb_Equipo4B.EleccionPremio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="mb-3">
        <asp:Label ID="Label1" runat="server" Text="Elegí tu premio: " CssClass="h3 mb-4"></asp:Label>
    </div>


    <div class="row">
        <%
            foreach (dominio.Articulo art in listaArticulos)
            {
    %>
        <div class='col-md-4 mb-4'>
            <div class="card h-100">

                <div id="carouselExampleFade<%=art.Id %>" class="carousel slide carousel-fade">

                    <div class="carousel-inner">
                        <%
                            for (int i = 0; i < art.Imagen.Count; i++)
                            {
                                if (i == 0)
                                {
                        %>
                        <div class="carousel-item active">
                            <img src="<% =art.Imagen[i].ImagenUrl %>" class="d-block w-100" alt="...">
                        </div>
                        <%
                            }
                            else
                            {
                        %>
                        <div class="carousel-item">
                            <img src="<% =art.Imagen[i].ImagenUrl %>" class="d-block w-100" alt="...">
                        </div>
                        <%
                                }
                            }
                        %>
                    </div>
                    <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleFade<%=art.Id %>" data-bs-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Previous</span>
                    </button>
                    <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleFade<%=art.Id %>" data-bs-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Next</span>
                    </button>

                </div>
                <div class="card-body">
                    <h5 class="card-title"><%= art.Nombre %></h5>
                    <p class="card-text"><%= art.Descripcion %></p>
                    <a href="IngresarDatos.aspx?id=<%=art.Id %>" class="btn btn-primary">Elegir</a>
                </div>
            </div>
        </div>
        <%
            }
    %>
    </div>

</asp:Content>
