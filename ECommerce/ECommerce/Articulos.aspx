<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="ECommerce.Articulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Timer ID="Timer" runat="server" Interval="1000" OnTick="Timer_Tick" Enabled="False">
    </asp:Timer>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer" EventName="Tick" />
        </Triggers>
        <ContentTemplate>
            <center>
            <div class="container-fluid">
                <div class="row">
                    <div class="col-md-12">
                        <h4>Articulos</h4>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="form-inline w-50 text-center">
                            <asp:TextBox ID="txFiltro" runat="server" placeholder="Buscar productos..." class="form-control w-75"></asp:TextBox>
                            <div class="w-25 text-center">
                                <asp:ImageButton ID="btFiltrar" runat="server" ImageUrl="~/Img/glass32.png" Height="32" Width="32" ImageAlign="Middle" OnClick="btFiltrar_Click" />
                            </div>
                        </div>
                        <br />
                            <asp:Label ID="lbMsg" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Medium" Font-Underline="False" ForeColor="#009900"></asp:Label>

                        <asp:Label ID="lblTimer" runat="server" Visible="False">0</asp:Label>                               

                    </div>
                </div>

            </div>
            </center>
                <hr />
                <div class="album py-3 bg-transparent">
                    <div class="container">
                        <div class="row" runat="server" id="dvArticulos">
                        </div>
                    </div>
                </div>
                <br />
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scripts" runat="server">
</asp:Content>
