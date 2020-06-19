<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ECommerce.Login" %>

<!DOCTYPE html>

<html lang="es" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <link href="~/css/Site.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" href="img/logo.png" type="image/png" sizes="32x32">
    <link rel="icon" href="img/logo.png" type="image/png" sizes="32x32">


    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

    <title>ECommerce - Iniciar Sesión</title>

</head>
<body>
    <form id="form1" runat="server">

        <div class="container">

            <br />
            <div class="row">
                <div class="col-md-4">
                </div>
                <div class="col-md-4 text-center">
                    <img alt="Logo" src="img/ecommerce.jpg" class="img-fluid" />
                    <br />
                    <br />
                </div>
                <div class="col-md-4">
                </div>
            </div>

            <div class="row">
                <div class="col-md-4">
                </div>
                <div class="col-md-4">
                    <h4>Iniciar Sesión</h4>
                </div>
                <div class="col-md-4">
                </div>
            </div>

            <div class="row">
                <div class="col-md-4">
                </div>
                <div class="col-md-4">
                    <label for="txUsuario">Usuario</label>
                    <asp:TextBox ID="txUsuario" runat="server" class="form-control"></asp:TextBox>
                    <br />
                </div>
                <div class="col-md-4">
                </div>
            </div>

            <div class="row">
                <div class="col-md-4">
                </div>
                <div class="col-md-4">
                    <label for="txContraseña">Contraseña</label>
                    <asp:TextBox ID="txContraseña" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                    <br />
                </div>
                <div class="col-md-4">
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                </div>
                <div class="col-sm-4 text-center">
                    <asp:Button ID="btIniciar" runat="server" Text="Iniciar Sesión" class="btn btn-primary btn-lg w-100" OnClick="btIniciar_Click" />
                </div>
                <div class="col-md-4">
                </div>
            </div>
            <div class="text-center">
                <br />
                <a class="p-2 text-dark" href="Signin.aspx">Registrarse</a><br />
            </div>
            <div class="row">
                <div class="col-md-4">
                </div>
                <div class="col-sm-4 text-center">
                    <br />
                    <asp:Label ID="lbMsg" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-md-4">
                </div>
            </div>
        </div>
    </form>


</body>
</html>
