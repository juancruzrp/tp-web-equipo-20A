<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DatosCliente.aspx.cs" Inherits="WebApplication2.DatosCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     
    <h1 id="aspnetTitle">NOMBRE</h1>
    <h2>Ingresa tus datos.</h2> 
    <asp:Label ID="lblDNI" runat="server" Text="DNI"></asp:Label>
    <asp:TextBox cssclass="form-control" ID="txtDNI" runat="server"></asp:TextBox>



</asp:Content>
