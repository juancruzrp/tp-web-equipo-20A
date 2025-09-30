<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Seleccion.aspx.cs" Inherits="WebApplication2.Seleccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>¡Selecciona el premio por el cual queres participar!</h2>   
    <br />
                
            <div class="container">
            <div class="row">
                <% foreach (Dominio.Articulo articulo in ListaArticulo) 
                   { 
                %>
                    <div class="col-4 mb-4"> 
                        <div class="card" style="border:1px solid #ccc; padding:10px;">
                        <div style="display:flex; gap:5px; justify-content:center; flex-wrap:wrap;">
                                <% foreach (var url in articulo.ImagenUrl)
                                   { 
                                %>
                                    <img src="<%= url %>" alt="Imagen <%= articulo.Nombre %>" 
                                         style="width:150px; height:150px; object-fit:cover; border:1px solid #aaa;">
                                <% 
                                   } 
                                %>
                            </div>

                            <div style="margin-top:5px; text-align:center;">
                                <h6><%= articulo.Nombre %></h6>
                                <p style="font-size:0.8rem;"><%= articulo.Descripcion %></p>
                                <asp:Button ID="Button1" CssClass="btn btn-sm btn-primary" runat="server" Text="Seleccionar" OnClick="btnSeleccionar_Click" />
                            </div>

                        </div>
                    </div>
                <% } %>
            </div>
        </div>

    
    
   </asp:Content>
