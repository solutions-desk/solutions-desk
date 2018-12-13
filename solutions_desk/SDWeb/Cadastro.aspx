<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="SDWeb.Cadastro" %>

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
    <form id="form1" runat="server">
   <div class="cadastro">
        <div class="container-cadastro">
            <a href="/login.aspx"><img class="logo" src="/public/images/logo.png"></a>

            <div class="py-2">
                <h1>Cadastro de cliente</h1>
            </div>
            <div>
                <div>
                    <label>Selecione o perfil</label>
                </div>
                <div class="d-flex mb-4">
                    <div class="custom-control custom-radio">
                        <input type="radio" id="customRadio1" name="customRadio" class="custom-control-input" checked="checked">
                        <label class="custom-control-label" for="customRadio1">Pessoa física</label>
                    </div>

                    <div class="custom-control custom-radio ml-4">
                        <input type="radio" id="customRadio2" name="customRadio" class="custom-control-input">
                        <label class="custom-control-label" for="customRadio2">Pessoa Jurídica</label>
                    </div>
                </div>
            </div>

            <div>
                <div class="row">
                    <div class="col input-container block">
                        <label for="txtNome">Nome*</label>
                        <input id="txtNome" type="text" placeholder="Digite seu nome completo" runat="server">
                    </div>
                </div>
                <div class="row">
                    <div class="col-12 col-sm-5 input-container block">
                        <label for="txtCPF">CPF*</label>
                        <input id="txtCPF" type="text" placeholder="_________-__" runat="server">
                    </div>
                </div>
                <div class="row">
                    <div class="col-12 col-sm-5 input-container block">
                        <label for="txtTelefone">Telefone*</label>
                        <input id="txtTelefone" type="text" placeholder="(xx) xxxxx-xxxx" runat="server">
                    </div>
                    <div class="col input-container block">
                        <label for="txtEmail">E-mail*</label>
                        <input id="txtEmail" type="text" placeholder="a@a.com" runat="server">
                    </div>
                </div>
                <div class="row">
                    <div class="col-12 col-sm-4 input-container block">
                        <label for="txtCep">CEP*</label>
                        <input id="txtCep" type="text" placeholder="_____-____" runat="server">
                    </div>
                    <div class="col input-container block">
                        <label for="txtEndereco">Endereço*</label>
                        <input id="txtEndereco" type="text" placeholder="Exemplo: Rua, Av, Viela" runat="server">
                    </div>
                    <div class="col-12 col-sm-2 input-container block">
                        <label for="txtNumero">Número*</label>
                        <input id="txtNumero" type="text" runat="server">
                    </div>
                </div>
                <div class="row">
                    <div class="col-12 col-sm-4 input-container block">
                        <label for="txtBairro">Bairro*</label>
                        <select id="txtBairro" runat="server">
                            <option value="n">Selecione</option>
                            <option value="b1">Jardim Bom Jesus</option>
                            <option value="b2">Vila Nova</option>
                            <option value="b3">Payol</option>
                            <option value="b4">Centro</option>
                        </select>
                    </div>
                    <div class="col input-container block">
                        <label for="txtCidade">Cidade*</label>
                        <select id="txtCidade" runat="server">
                            <option value="n">Selecione</option>
                            <option value="b1">Pirapora do Bom Jesus</option>
                            <option value="b1">Santana de parnaiba</option>
                            <option value="b2">Barueri</option>
                            <option value="b3">Osasco</option>
                            <option value="b4">Itapevi</option>
                        </select>
                    </div>
                    <div class="col-12 col-sm-2 input-container block">
                        <label for="txtUF">UF*</label>
                        <select id="txtUF" runat="server">
                            <option value="b1">SP</option>
                            <option value="b1">MT</option>
                            <option value="b2">PR</option>
                        </select>
                    </div>
                </div>
                <div class="row">
                    <div class="col-12 col-sm-4 input-container block">
                        <label for="txtSenha">Senha</label>
                        <input id="txtSenha" type="password" runat="server">
                    </div>
                    <div class="col-12 col-sm-4 input-container block">
                        <label for="txtConfirmarSenha">Confirmar senha</label>
                        <input id="txtConfirmarSenha" type="password" runat="server">
                    </div>
                </div>
            </div>
            <div class="row mt-4">  
                <div class="col pt-3">
                    <a class="botao icone ghost" href="/login.aspx">
                        <i class="material-icons">arrow_back</i>
                        Voltar
                    </a>
                </div>
                <div class="col-6 col-sm-3 text-right">
                    <asp:Button ID="entrar" runat="server" Text="CADASTRAR" class="botao  primary" OnClick="entrar_Click" />
                    
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
