<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PruebaTecnica._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Prueba Técnica Daniel Zapata</title>
    <!-- CSS Login -->
    <link href="CSS/Login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="panelLogin" runat="server">
        <table style="height: 124px; width: 267px">
            <tr>
                <td>Usuario:</td>
                <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Contraseña</td>
                <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td id="lbkIngresar" title="Ingresar">
                    <asp:LinkButton ID="Ingresar" runat="server" OnClick="Ingresar_Click">Ingresar</asp:LinkButton>
                </td>
            </tr>
        </table>    
    
    </div>
        <p>
            <asp:Label ID="lblAdv" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
