<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Parcial_3.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Parcial 3</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Gestion de Casos</h1>

        <asp:Label ID="lblCasoNombre" runat="server" Text="Nombre del Caso:" />
        &nbsp;
        <asp:TextBox ID="txtCasoNombre" runat="server" />
        <br />
        <br />

        <asp:Label ID="lblFechaInicio" runat="server" Text="Fecha de Inicio:" />
        &nbsp;<asp:TextBox ID="txtFechaInicio" runat="server" TextMode="Date" />
        <br />
        <br />

        <asp:Label ID="lblFechaVencimiento" runat="server" Text="Fecha de Vencimiento:" />
        &nbsp;<asp:TextBox ID="txtFechaVencimiento" runat="server" TextMode="Date" />
        <br />
        <br />

        <asp:Label ID="lblAbogado" runat="server" Text="Abogado Asignado:" />
        &nbsp;<asp:TextBox ID="txtAbogado" runat="server" />
        <br />
        <br />

        <asp:Label ID="lblCliente" runat="server" Text="Nombre del Cliente:" />
        &nbsp;<asp:TextBox ID="txtCliente" runat="server" />
        <br />
        <br />

        <asp:Label ID="lblEstado" runat="server" Text="Estado:" />
        <asp:DropDownList ID="Estado" runat="server">
            <asp:ListItem Text="Abierto" Value="Abierto" />
            <asp:ListItem Text="En Proceso" Value="En Proceso" />
            <asp:ListItem Text="Cerrado" Value="Cerrado" />
        </asp:DropDownList>
        <br />
        <br />

        <asp:Label ID="lblDescripcion" runat="server" Text="Descripción:" />
        <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" Rows="3" Columns="50" />
        <br />
        <br />

        &nbsp;
<asp:Button ID="btnBuscarCaso" runat="server" Text="Buscar Caso" OnClick="btnBuscarCaso_Click" />


        <asp:Button ID="btnGuardar" runat="server" Text="Guardar Caso" OnClick="btnGuardar_Click" />&nbsp;&nbsp;
        <asp:Button ID="BtnEliminarCaso" runat="server" Text="Eliminar Caso" OnClick="BtnEliminarCaso_Click" />
        <br />
        <br />
        <br /><br />

        <asp:GridView ID="gvCasos" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="CasoID" HeaderText="ID" />
                <asp:BoundField DataField="CasoNombre" HeaderText="Caso" />
                <asp:BoundField DataField="FechaInicio" HeaderText="Inicio" DataFormatString="{0:yyyy-MM-dd}" />
                <asp:BoundField DataField="FechaVencimiento" HeaderText="Vencimiento" DataFormatString="{0:yyyy-MM-dd}" />
                <asp:BoundField DataField="AbogadoAsignado" HeaderText="Abogado" />
                <asp:BoundField DataField="NombreCliente" HeaderText="Cliente" />
                <asp:BoundField DataField="EstadoCaso" HeaderText="Estado" />
                <asp:BoundField DataField="DescripcionCaso" HeaderText="Descripción" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
