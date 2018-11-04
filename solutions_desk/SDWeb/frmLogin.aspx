<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="SDWeb.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login</h1>
            <div>
                <label>Nome cliente: </label> <asp:Label ID="lblNomeCliente" runat="server" Text=""></asp:Label>
            </div>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Usuário"></asp:Label>
            </p>
            <p>
                <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
            </p>
            <p>
                <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Entrar" OnClick="Button1_Click" />
            </p>
            <p>&nbsp;</p>


        </div>
    </form>
</body>
</html>
