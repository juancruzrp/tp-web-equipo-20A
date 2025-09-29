<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Seleccion.aspx.cs" Inherits="WebApplication2.Seleccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>¡Selecciona el premio por el cual queres participar!</h2>   
    <br />

            <%foreach (Dominio.Articulo articulo in ListaArticulo)
              {
            %>
              <div class="row row-cols-1 row-cols-md-3 g-4">

                  <div class="col">
                    <div class="card">
                      <img src="<%:articulo.ImagenUrl %>" class="card-img-top" alt="...">
                      <div class="card-body">
                        <h5 class="card-title"><%: articulo.Nombre %></h5>
                        <p class="card-text"><%:articulo.Descripcion %></p>
                        <asp:Button ID="btnSeleccionar" cssclass="btn btn-primary" OnClick="btnSeleccionar_Click" runat="server" Text="Seleccionar" />
                      </div>
                    </div>
                  </div>

              </div>
           <% } %>

</asp:Content>
