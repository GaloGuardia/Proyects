<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetallesArticulo.aspx.cs" Inherits="ECommerce.DetallesArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="album py-3 bg-transparent">
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
                    <label for="txtUsuario">Nombre de usuario</label>
                    asp:image
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

                <div class="col-sm-4 text-center">
                    <asp:Button ID="btnRegistrarse" runat="server" Text="Registrarse" class="btn btn-primary btn-lg" OnClick="btnRegistrarse_Click" />
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

    <br />

    <div class="row">

        <div class="col-md-4">
        </div>

        <div class="col-sm-4 text-center">
            <asp:Button ID="btnBack" runat="server" class="btn btn-primary btn-lg" OnClick="btnBack_Click" Text="Volver" />
        </div>

        <div class="col-md-4">
        </div>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scripts" runat="server">
</asp:Content>
