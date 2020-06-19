<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Buscador.aspx.cs" Inherits="TutuCanchas_GP1.Buscador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>


            <br />
            <div class="container" style="font-size: smaller">

                <div class="row">
                    <div class="col-md-12">
                        <h3>Buscador</h3>
                    </div>
                </div>
                <div class="row">

                    <div class="col-md-6">

                        <asp:Label ID="Label2" runat="server" Text="Tipo de Cancha"></asp:Label>
                        <asp:DropDownList ID="ddTipoCancha" runat="server" class="custom-select d-block w-100" Width="100%"></asp:DropDownList>

                        <br />
                        <asp:Label ID="Label3" runat="server" Text="Precio"></asp:Label>
                        <asp:TextBox ID="txPrecio" runat="server" class="form-control" TextMode="Number"></asp:TextBox>

                        <br />
                        <asp:Label ID="Label4" runat="server" Text="Zonas"></asp:Label>
                        <asp:DropDownList ID="ddZonas" runat="server" class="custom-select d-block w-100" Width="100%"></asp:DropDownList>

                        <br />

                    </div>

                    <div class="col-md-6">
                        <asp:Label ID="Label5" runat="server" Text="Fecha:"></asp:Label>
                        <asp:Calendar ID="cal" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                            <NextPrevStyle VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#808080" />
                            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                            <SelectorStyle BackColor="#CCCCCC" />
                            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <WeekendDayStyle BackColor="#FFFFCC" />
                        </asp:Calendar>
                    </div>

                </div>
                <div class="row">

                    <div class="col-md-12 text-right">
                        <br />
                        <asp:Button ID="btBuscar" runat="server" Text="Buscar" class="btn btn-primary btn-lg" OnClick="btBuscar_Click" />
                        <br />
                        <hr />
                    </div>

                    <asp:Label ID="lbMsg" runat="server"></asp:Label>
                </div>
                <div class="row">
                    <div class="col-md-12 text-center">
                        <asp:GridView ID="gvCanchas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="gvCanchas_RowCommand" Width="100%">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:ButtonField ButtonType="Button" CommandName="Reservar" Text="Reservar" />
                            </Columns>
                            <EditRowStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#E3EAEB" />
                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F8FAFA" />
                            <SortedAscendingHeaderStyle BackColor="#246B61" />
                            <SortedDescendingCellStyle BackColor="#D4DFE1" />
                            <SortedDescendingHeaderStyle BackColor="#15524A" />
                        </asp:GridView>

                        <br />
                        <br />
                    </div>
                </div>
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>


</asp:Content>
