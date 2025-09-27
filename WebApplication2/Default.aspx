<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">NOMBRE</h1>
            <p class="lead">En nuestra tienda vas a encontrar una amplia variedad de monitores, periféricos, gabinetes y mucho mas para que armes o mejores tu PC según tus necesidades.</p>
        </section>
      
         <div id="carouselExampleCaptions" class="carousel slide">
          <div class="carousel-indicators">
            <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
            <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="1" aria-label="Slide 2"></button>
            <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="2" aria-label="Slide 3"></button>
          </div>
          <div class="carousel-inner">
            <div class="carousel-item active">
              <img src="https://i.blogs.es/a3345c/perifericos-gaming/1366_2000.jpg" class="d-block w-100" alt="...">
              <div class="carousel-caption d-none d-md-block">
                <h5>PERIFERICOS</h5>
                <p>Teclados, auriculares, mouse y mucho más</p>
              </div>
            </div>
            <div class="carousel-item">
              <img src="https://cdn.mos.cms.futurecdn.net/toQwYqxAEQCBaWc7r2b5iP.jpg" class="d-block w-100" alt="...">
              <div class="carousel-caption d-none d-md-block">
                <h5>MONITORES</h5>
                <p>Disfrutá de cada detalle con resolución Full HD.</p>
              </div>
            </div>
            <div class="carousel-item">
              <img src="https://ocelot.com.mx/wp-content/uploads/2025/01/PORTADA_WCUBE2.jpg" class="d-block w-100" alt="...">
              <div class="carousel-caption d-none d-md-block">
                <h5>GABINETES</h5>
                <p>Diseños modernos con iluminación que destacan tu setup.</p>
              </div>
            </div>
          </div>
          <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Previous</span>
          </button>
          <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Next</span>
          </button>
        </div>


    </main>

</asp:Content>
