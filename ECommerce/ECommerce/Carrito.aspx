<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="ECommerce.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="row">

        <div class="col-md-3">
        </div>

        <div class="col-sm-6">
            <asp:GridView ID="gvCarrito" runat="server" CellPadding="4" BackColor="White" BorderColor="Black" BorderStyle="None" BorderWidth="1px">
                <Columns>
                    <asp:ButtonField ButtonType="Button" HeaderText="Eliminar del Carrito" Text="Eliminar" />
                </Columns>
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
            <center>
                <asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#990000" Text="Message"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnComprar" runat="server" Text="Comprar" class="btn btn-primary btn-lg" OnClick="btnComprar_Click" />
                <br />
                <br />
                <asp:Button ID="btnVaciar" runat="server" Text="Vaciar Carrito" class="btn btn-primary btn-lg" OnClick="btnVaciar_Click" />
            </center>
        </div>

        <div class="col-md-3">
        </div>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scripts" runat="server">
</asp:Content>
