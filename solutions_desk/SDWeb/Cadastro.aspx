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
                        <label for="nome">Nome*</label>
                        <input id="nome" type="text" placeholder="Digite seu nome completo">
                    </div>
                </div>
                <div class="row">
                    <div class="col-5 input-container block">
                        <label for="cpf">CPF*</label>
                        <input id="cpf" type="text" placeholder="_________-__">
                    </div>
                </div>
                <div class="row">
                    <div class="col-5 input-container block">
                        <label for="telefone">Telefone*</label>
                        <input id="telefone" type="text" placeholder="(xx) xxxxx-xxxx">
                    </div>
                    <div class="col input-container block">
                        <label for="email">E-mail*</label>
                        <input id="email" type="text" placeholder="a@a.com">
                    </div>
                </div>
                <div class="row">
                    <div class="col-4 input-container block">
                        <label for="cep">CEP*</label>
                        <input id="cep" type="text" placeholder="_____-____">
                    </div>
                    <div class="col input-container block">
                        <label for="endereco">Endereço*</label>
                        <input id="endereco" type="text" placeholder="Exemplo: Rua, Av, Viela">
                    </div>
                    <div class="col-2 input-container block">
                        <label for="numero">Número*</label>
                        <input id="numero" type="text">
                    </div>
                </div>
                <div class="row">
                    <div class="col-4 input-container block">
                        <label for="bairro">Bairro*</label>
                        <select>
                            <option value="n">Selecione</option>
                            <option value="b1">Jardim Bom Jesus</option>
                            <option value="b2">Vila Nova</option>
                            <option value="b3">Payol</option>
                            <option value="b4">Centro</option>
                        </select>
                    </div>
                    <div class="col input-container block">
                        <label for="cidade">Cidade*</label>
                        <select>
                            <option value="n">Selecione</option>
                            <option value="b1">Pirapora do Bom Jesus</option>
                            <option value="b1">Santana de parnaiba</option>
                            <option value="b2">Barueri</option>
                            <option value="b3">Osasco</option>
                            <option value="b4">Itapevi</option>
                        </select>
                    </div>
                    <div class="col-2 input-container block">
                        <label for="estado">UF*</label>
                        <select>
                            <option value="b1">SP</option>
                            <option value="b1">MT</option>
                            <option value="b2">PR</option>
                        </select>
                    </div>
                </div>
            </div>
            <div class="row mt-4">
                <div class="col">
                    <button class="botao icone ghost" onclick="location.href='/login.aspx';">
                        <i class="material-icons">arrow_back</i>
                        Voltar
                    </button>
                </div>
                <div class="col text-right">
                    <button class="botao  primary" id="entrar" onclick="location.href='/historicoChamados.aspx';">Cadastrar</button>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
