<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CargaExitosa.aspx.cs" Inherits="WebApplication2.CargaExitosa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Registro exitoso</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="bg-light d-flex justify-content-center align-items-center vh-100">
    <form id="formRegistroExitoso" runat="server">
        <div class="text-center p-4 bg-success bg-opacity-10 border border-success rounded shadow" style="max-width: 600px;">
            <h2 class="text-success mb-3">¡Registro completado con éxito!</h2>
            <p>Gracias por participar en nuestra promoción.</p>
            <p>Te deseamos mucha suerte en el sorteo de los premios.</p>
            <p>¡Que tengas un excelente día!</p>
            <p>En breve serás redirigido a la página de inicio.</p>
            <p>De no ser así, por favor, presiona el boton a continuación.</p>
            <a href="Default.aspx" class="btn btn-outline-success mt-3">Ir a la página de inicio</a>
        </div>
    </form>
    <script>
        setTimeout(function () {
            window.location.href = "Default.aspx";}, 5000); // 5000 milisegundos = 5 segundos
</script>
</body>
</html>
