<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio154.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="Suma de Numeros"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        </div>
        <asp:Label ID="Label2" runat="server" Font-Size="Larger" Text="Numero 1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt1" runat="server" Height="26px"></asp:TextBox>
        <br />
        <p>
            <asp:Label ID="Label3" runat="server" Font-Size="Larger" Text="Numero 2"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt2" runat="server" Height="21px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnSumar" runat="server" Font-Size="Larger" Height="50px" OnClick="btnSumar_Click" Text="Sumar" Width="104px" />
        </p>
        <asp:Label ID="Label4" runat="server" Font-Size="Larger" Text="La suma es: "></asp:Label>
        <asp:Label ID="resultado" runat="server" Font-Size="Larger"></asp:Label>
    </form>
</body>
</html>
