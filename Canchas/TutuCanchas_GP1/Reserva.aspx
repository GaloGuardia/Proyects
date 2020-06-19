<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reserva.aspx.cs" Inherits="TutuCanchas_GP1.Reserva" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <div class="container">

        <div class="row">

            <div class="col-md-12">
            
                <h3>Confirmar Reserva</h3>
            
                <asp:Label ID="lbReserva" runat="server"></asp:Label>
                
                <asp:Button ID="btConfirmar" runat="server" Text="Confirmar" OnClick="btConfirmar_Click" />
                <asp:Button ID="btCancelar" runat="server" Text="Cancelar" OnClick="btCancelar_Click" />

            </div>

        </div>

    </div>

</asp:Content>
