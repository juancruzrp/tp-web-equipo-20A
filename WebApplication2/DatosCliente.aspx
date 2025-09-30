<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DatosCliente.aspx.cs" Inherits="WebApplication2.DatosCliente" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Ingresa tus datos</h2>

     <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        CssClass="alert alert-danger" 
        HeaderText="Por favor, completa los campos obligatorios:" />

<div>
    <asp:Label ID="lblDocumento" runat="server" Text="Documento"></asp:Label>
    <asp:TextBox CssClass="form-control" ID="txtDocumento" runat="server"></asp:TextBox>
    <asp:Button ID="btnBuscarDNI" CssClass="btn btn-secondary" 
                OnClick="btnBuscarDNI_Click" runat="server" Text="Buscar" />
    <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" Visible="false"></asp:Label>
</div>

    <div class="row g-3">
        <div class="col">
            <asp:Label ID="lblNombre" runat="server" Text="Nombre/s"></asp:Label>
            <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre"
                ErrorMessage="El nombre es obligatorio." ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>

        <div class="col">
            <asp:Label ID="lblApellido" runat="server" Text="Apellido/s"></asp:Label>
            <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido"
                ErrorMessage="El apellido es obligatorio." ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>

        <div class="col">
            <asp:Label ID="lblEmail" runat="server" Text="Mail"></asp:Label>
            <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
                ErrorMessage="El mail es obligatorio." ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>

    </div>
    <div class="row g-3">
        <div class="col">
            <div class="dropdown">
                <asp:Label ID="lblPartido" runat="server" Text="Partido:"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlPartido" CssClass="btn btn-secondary dropdown-toggle" runat="server"></asp:DropDownList>
            </div>
        </div>

        <div class="col">
            <asp:Label ID="lblDireccion" runat="server" Text="Direccion"></asp:Label>
            <asp:TextBox ID="txtDireccion" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion"
                ErrorMessage="La dirección es obligatoria." ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
        <div class="col">
            <asp:Label ID="lblCodigoPostal" runat="server" Text="Codigo Postal"></asp:Label>
            <asp:TextBox ID="txtCodigoPostal" CssClass="form-control" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rfvCodigoPostal" runat="server" ControlToValidate="txtCodigoPostal"
                ErrorMessage="El código postal es obligatorio." ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
    </div>


    <br />
    <div>
           <asp:CheckBox ID="chkTerminos" runat="server" />
    <asp:Label ID="lblTerminos" runat="server" Text="Acepto los terminos y condiciones."></asp:Label>
    <asp:CustomValidator ID="cvTerminos" runat="server" 
        ErrorMessage="Debe aceptar los términos y condiciones." 
        ForeColor="Red" 
        Display="Dynamic"
        OnServerValidate="cvTerminos_ServerValidate"></asp:CustomValidator>
    </div>
    <br />
    <div class="row g-2">
        <div>
            <asp:Button ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" Text="Aceptar" />
            <asp:Button ID="btnCancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click" runat="server" Text="Cancelar" />
        </div>
    </div>


</asp:Content>
