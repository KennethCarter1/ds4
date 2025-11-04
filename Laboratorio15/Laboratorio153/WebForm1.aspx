<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio153.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            width: 171px;
        }
        #txtNombre {
            width: 157px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Introduzca un Texto"></asp:Label>
        <p>
            <asp:TextBox ID="txtNombre" runat="server" Width="157px"></asp:TextBox><asp:Button ID="btnSaludo" runat="server" OnClick="btnSaludo_Click" Text="Enviar Saludo!" />
        </p>
    </form>
</body>
</html>
