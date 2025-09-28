<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DatosCliente.aspx.cs" Inherits="WebApplication2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     
    <h2>Ingresa tus datos</h2> 
    <asp:Label ID="lblDNI" runat="server" Text="DNI"></asp:Label>
    <asp:TextBox cssclass="form-control" ID="txtDNI" runat="server"></asp:TextBox>


  <div class="row g-3">
    <div class="col">
        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombre" cssclass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="col">
        <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
        <asp:TextBox ID="txtApellido" cssclass="form-control" runat="server"></asp:TextBox>
    </div>
  </div>


</asp:Content>
