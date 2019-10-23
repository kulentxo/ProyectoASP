<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="PruebaProyecto1.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:label runat="server" text="Nombre:"></asp:label><br />
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
            <asp:label runat="server" text="Apellido:"></asp:label><br />
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox><br />
            <asp:label runat="server" text="Fecha de Nacimiento:"></asp:label><br />
            <asp:TextBox ID="txtFec" runat="server"></asp:TextBox><br />
            <asp:label runat="server" text="Usuario:"></asp:label><br />
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox><br />
            <asp:label runat="server" text="Contraseña:"></asp:label><br />
            <asp:TextBox ID="txtPass" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="txtPass2" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click"/>
        </div>
        <div>
             <asp:label runat="server" text="Usuario:"></asp:label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:label runat="server" text="Contraseña:"></asp:label><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnIniciar" runat="server" Text="Iniciar Sesion" OnClick="btnIniciar_Click"/>
        </div>
    </form>
</body>

</html>
