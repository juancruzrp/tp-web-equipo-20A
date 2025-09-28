<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DatosCliente.aspx.cs" Inherits="WebApplication2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     
    <h1 id="aspnetTitle">Inicia sesion</h1>
    <h2>Ingresa tus datos</h2> 
    <asp:Label ID="lblDNI" runat="server" Text="DNI"></asp:Label>
    <asp:TextBox cssclass="form-control" ID="txtDNI" runat="server"></asp:TextBox>



</asp:Content>
