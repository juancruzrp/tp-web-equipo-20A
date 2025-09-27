<%@ Page Title="Promo Ganá" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Promocion.aspx.cs" Inherits="WebApplication2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2>¡Participa por grandes premios!</h2>        
        <br />
        <p>Ingresa tu código para participar.</p>
        <form>
          <div class="mb-3">
            <input type="codigo" class="form-control" id="codigoIngresado" aria-describedby="codigoHelp">
          </div>              
          <button type="siguiente" class="btn btn-primary">Siguiente</button>
        </form>        
    </main>
</asp:Content>
