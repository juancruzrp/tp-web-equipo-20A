<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Seleccion.aspx.cs" Inherits="WebApplication2.Seleccion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>¡Selecciona el premio por el cual queres participar!</h2>   
    <br />

    <div class="container">
        <div class="row">
            <asp:Repeater ID="rptArticulos" runat="server" OnItemDataBound="rptArticulos_ItemDataBound">
                <ItemTemplate>
                    <div class="col-4 mb-4">
                        <div class="card" style="border:1px solid #ccc; padding:10px;">
                            
                           
                            <div id="carousel_<%# Eval("Id") %>" class="carousel slide" data-bs-ride="carousel">
                                <div class="carousel-inner">
                                    <asp:Repeater ID="rptImagenes" runat="server">
                                        <ItemTemplate>
                                            <div class='carousel-item <%# (Container.ItemIndex == 0 ? "active" : "") %>'>
                                                <img src='<%# Container.DataItem %>' 
                                                     class="d-block w-100"
                                                     style="height:200px; object-fit: contain;" />
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>

                              
                                <button class="carousel-control-prev" type="button" data-bs-target="#carousel_<%# Eval("Id") %>" data-bs-slide="prev">
                                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                    <span class="visually-hidden">Anterior</span>
                                </button>
                                <button class="carousel-control-next" type="button" data-bs-target="#carousel_<%# Eval("Id") %>" data-bs-slide="next">
                                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                    <span class="visually-hidden">Siguiente</span>
                                </button>
                            </div>

                            
                            <div style="margin-top:15px; text-align:center;">
                                <h6><%# Eval("Nombre") %></h6>
                                <p style="font-size:0.8rem;"><%# Eval("Descripcion") %></p>
                                <asp:Button ID="btnSeleccionar" CssClass="btn btn-sm btn-primary" runat="server"
                                            Text="Seleccionar"
                                            CommandArgument='<%# Eval("Id") %>'
                                            OnCommand="btnSeleccionar_Command" />
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>

