<%@ Page Title="Promo Ganá" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Promocion.aspx.cs" Inherits="WebApplication2.Promocion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2>¡Participa por grandes premios!</h2>        
       <br />
        <form>
          <div class="mb-3">
            <asp:Label ID="lblCodigo" cssclass="form-label" runat="server" Text="Ingresa el código de tu voucher."></asp:Label>
            <asp:TextBox  ID="txtCodigo" cssclass="form-control" runat="server"></asp:TextBox>
          </div>              
        <asp:Button ID="btnSiguiente" CssClass="btn btn-primary" OnClick="btnSiguiente_Click" runat="server" Text="Siguiente" />
        </form>        
    </main>
</asp:Content>
