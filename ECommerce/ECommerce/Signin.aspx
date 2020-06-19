<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signin.aspx.cs" Inherits="ECommerce.Signin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <link href="~/css/Site.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" href="img/pelotita.png" type="image/png" sizes="32x32">
    <link rel="icon" href="img/pelotita.png" type="image/png" sizes="32x32">

    <title>ECommerce - Registrarse</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">                
                <div class="row">

                    <div class="col-md-4">
                    </div>

                    <div class="col-md-4">
                        <h3>&nbsp;</h3>
                        <h3>Registrarse</h3>
                    </div>

                    <div class="col-md-4">
                    </div>

                </div>

                <div class="row">

                    <div class="col-md-4">
                    </div>

                    <div class="col-md-4">
                        <label for="txtNombre">Nombre</label>
                        <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
                        <br />
                    </div>

                    <div class="col-md-4">
                    </div>
                </div>

                <div class="row">

                    <div class="col-md-4">
                    </div>

                    <div class="col-md-4">
                        <label for="txtUsuario">Nombre de usuario</label>
                        <asp:TextBox ID="txtUsuario" runat="server" class="form-control" MaxLength="10"></asp:TextBox>
                        <br />
                    </div>

                    <div class="col-md-4">
                    </div>
                </div>

                <div class="row">

                    <div class="col-md-4">
                    </div>

                    <div class="col-md-4">
                        <label for="txtContraseña">Contraseña</label>
                        <asp:TextBox ID="txtContraseña" runat="server" class="form-control" TextMode="Password" MaxLength="10"></asp:TextBox>
                        <br />
                    </div>

                    <div class="col-md-4">
                    </div>

                </div>

                <div class="row">

                    <div class="col-md-4">
                    </div>

                    <div class="col-md-4">
                        <label for="txtContraseña2">Confirmar contraseña</label>
                        <asp:TextBox ID="txtContraseña2" runat="server" class="form-control" TextMode="Password" MaxLength="10"></asp:TextBox>
                        <br />
                    </div>

                    <div class="col-md-4">
                    </div>

                </div>

                <div class="row">

                    <div class="col-md-4">
                    </div>

                    <div class="col-md-4">
                        <label for="txtEmail">Correo electrónico</label>
                        <asp:TextBox ID="txtEmail" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
                        <br />
                    </div>

                    <div class="col-md-4">
                    </div>

                </div>

                <div class="row">

                    <div class="col-md-4">
                    </div>

                    <div class="col-md-4">
                        <label for="txtTel">Teléfono</label>
                        <asp:TextBox ID="txtTel" runat="server" class="form-control"></asp:TextBox>
                        <br />
                    </div>

                    <div class="col-md-4">
                    </div>

                </div>

                <div class="row">

                    <div class="col-md-4">
                    </div>

                    <div class="col-md-4">
                        <label for="txtDir">Dirección</label>
                        <asp:TextBox ID="txtDir" runat="server" class="form-control"></asp:TextBox>
                        <br />
                    </div>

                    <div class="col-md-4">
                    </div>
                </div>

                <div class="row">

                    <div class="col-md-4">
                    </div>

                    <div class="col-sm-4 text-center">
                        <asp:Button ID="btnSignin" runat="server" Text="Registrarse" class="btn btn-primary btn-lg" OnClick="btnSignin_Click" />
                    </div>

                    <div class="col-md-4">                        
                    </div>

                </div>                
                <div class="row">

                    <div class="col-md-4">
                    </div>

                    <div class="col-sm-4 text-center">
                        <br />
                        <asp:Label ID="lbMsg" runat="server"></asp:Label>
                    </div>

                    <div class="col-md-4">
                    </div>

                </div>
            </div>
        </div>
    </form>
</body>
</html>