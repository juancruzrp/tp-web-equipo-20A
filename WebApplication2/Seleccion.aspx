<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Seleccion.aspx.cs" Inherits="WebApplication2.Seleccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>¡Selecciona el premio por el cual queres participar!</h2>   
    <br />
                
            <div class="container">
    <div class="row">
        <asp:Repeater ID="rptArticulos" runat="server">
            <ItemTemplate>
                <div class="col-4 mb-4">
                    <div class="card" style="border:1px solid #ccc; padding:10px;">
                        <div style="display:flex; gap:5px; justify-content:center; flex-wrap:wrap;">
                            <asp:Repeater ID="rptImagenes" runat="server" DataSource='<%# Eval("ImagenUrl") %>'>
                                <ItemTemplate>
                                    <img src='<%# Container.DataItem %>' 
                                         style="width:150px; height:150px; object-fit:cover; border:1px solid #aaa;" />
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>

                        <div style="margin-top:5px; text-align:center;">
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
