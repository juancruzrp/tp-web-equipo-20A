<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DatosCliente.aspx.cs" Inherits="WebApplication2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Ingresa tus datos</h2>
    <asp:Label ID="lblDNI" runat="server" Text="DNI"></asp:Label>
    <asp:TextBox CssClass="form-control" ID="txtDNI" runat="server"></asp:TextBox>


    <div class="row g-3">
        <div class="col">
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col">
            <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
            <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col">
            <asp:Label ID="lblMail" runat="server" Text="Mail"></asp:Label>
            <asp:TextBox ID="txtMail" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row g-3">
        <div class="col">
            <asp:Label ID="lblDireccion" runat="server" Text="Direccion"></asp:Label>
            <asp:TextBox ID="txtDireccion" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col">
            <asp:Label ID="lblCiudad" runat="server" Text="Ciudad"></asp:Label>
            <asp:TextBox ID="txtCiudad" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col">
            <asp:Label ID="lblCodigoPostal" runat="server" Text="Codigo Postal"></asp:Label>
            <asp:TextBox ID="txtCodigoPostal" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
    </div>
    <asp:CheckBox ID="chkTerminos" runat="server" />
    <asp:Label ID="lblTerminos" runat="server" Text="Acepto los terminos y condiciones."></asp:Label>
    <div class="col">
        <asp:Button ID="btnAceptar" CssClass="btn btn-primary" runat="server" Text="Aceptar" />
        <asp:Button ID="btnCancelar" CssClass="btn btn-primary" runat="server" Text="Cancelar" />
    </div>


</asp:Content>
