<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Seleccion.aspx.cs" Inherits="WebApplication2.Seleccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>¡Selecciona el premio por el cual queres participar!</h2>   
    <br />
  <div class="d-flex gap-3">
  <div class="card" style="width: 18rem;">
    <img src="https://acdn-us.mitiendanube.com/stores/086/438/products/mochila-at-hunter-1450811-401f5d44651fb852dc16814196062997-640-0.jpg" class="card-img-top" alt="...">
    <div class="card-body">
      <h5 class="card-title">Mochila Notebook</h5>
      <p class="card-text">La mejor mochila que vas a tener.</p>
        <asp:Button Cssclass="btn btn-primary" ID="btnSeleccionar1" OnClick="btnSeleccionar1_Click" runat="server" Text="Seleccionar" />
    </div>
  </div>

  <div class="card" style="width: 18rem;">
    <img src="https://s3-sa-east-1.amazonaws.com/saasargentina/nr9CHMxZBsfXPMxr3tgX/imagen" class="card-img-top" alt="...">
    <div class="card-body">
      <h5 class="card-title">Auriculares Gamer</h5>
      <p class="card-text">Escuchá los pasos del enemigo.</p>
        <asp:Button Cssclass="btn btn-primary" ID="btnSeleccionar2" OnClick="btnSeleccionar2_Click" runat="server" Text="Seleccionar" />
    </div>
  </div>

  <div class="card" style="width: 18rem;">
    <img src="https://donatocomputacion.com.ar/wp-content/uploads/2025/04/Logi-g300s.jpg" class="card-img-top" alt="...">
    <div class="card-body">
      <h5 class="card-title">Mouse Gamer</h5>
      <p class="card-text">Precisión es mi segundo nombre.</p>
        <asp:Button Cssclass="btn btn-primary" ID="btnSeleccionar3" OnClick="btnSeleccionar3_Click" runat="server" Text="Seleccionar" />
    </div>
  </div>
</div>

</asp:Content>
