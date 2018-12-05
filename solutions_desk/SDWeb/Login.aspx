<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SDWeb.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, minimum-scale=1, maximum-scale=1">
    <title>Solutions Desk</title>
    <link rel="stylesheet" href="/public/css/bootstrap.min.css">
    <link rel="stylesheet" href="/public/fonts/material-icons/material-icons.css">
    <link rel="stylesheet" href="/public/fonts/roboto/roboto.css">
    <link rel="stylesheet" href="/public/css/main.css">
    <link rel="icon" type="image/png" href="/public/images/favicon.png" />
    <script src="/public/js/jquery-2.2.4.min.js"></script>
</head>
<body>
    <form runat="server">
        <div class="login">
            <div class="container-login">
                <a href="javascript:void(0);"><img class="logo" src="/public/images/logo.png"></a>

                <div class="py-2">
                    <h1>Login</h1>
                    <p>Seu acesso lhe permite visualizar seus chamados de forma simples e descomplicada</p>
                </div>

                <div>
                    <div class="input-container">
                        <label for="email">E-mail</label>
                        <input id="email" type="e-mail" runat="server" placeholder="Digite seu e-mail" autocomplete="off">
                    </div>

                    <div class="input-container">
                        <label for="senha">Senha</label>
                        <input id="senha" type="password" placeholder="Digite sua senha" autocomplete="off" runat="server">
                        <i class="material-icons mostrar-senha">remove_red_eye</i>
                    </div>

                    <div>
                        <a href="javascript:void(0);">Esqueci minha senha</a>
                    </div>

                    <div class="row mt-4">
                        <div class="col">
                            <button class="botao block" onclick="location.href='/cadastro.aspx  ';">Cadastre-se</button>
                        </div>
                        <div class="col">
                            <asp:Button ID="entrar" class="botao block primary" runat="server" Text="ENTRAR" OnClick="entrar_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
