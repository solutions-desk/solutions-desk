<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="AbrirChamado.aspx.cs" Inherits="SDWeb.AbrirChamado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="sub-menu hide-mobile">
            <a href="javascript:void(0);" class="botao-novo-chamado">
                <i class="material-icons">add</i>
                Novo Chamado
            </a>

            <span class="separador"></span>

            <div class="lista-chamados">
                <div>
                    <strong>Chamados recentes</strong>
                </div>

                <div class="chamado encerrado" onclick="location.href='/detalheChamado.aspx';">
                    <p>Nº: <strong>448948</strong></p>
                    <p>Cliente: <strong>Juão Neves</strong></p>
                    <p>Aberto em: <strong>01/05/2018</strong></p>
                </div>

                <div class="chamado tecnico" onclick="location.href='/detalheChamado.aspx';">
                    <p>Nº: <strong>448948</strong></p>
                    <p>Cliente: <strong>Juão Neves</strong></p>
                    <p>Aberto em: <strong>01/05/2018</strong></p>
                </div>

                <div class="chamado andamento" onclick="location.href='/detalheChamado.aspx';">
                    <p>Nº: <strong>448948</strong></p>
                    <p>Cliente: <strong>Juão Neves</strong></p>
                    <p>Aberto em: <strong>01/05/2018</strong></p>
                </div>
            </div>
        </div>

        <div class="conteudo conteudo-detalhe-container d-flex">
            <div class="conteudo-chamado">
                <h1 class="mt-0">Abrir chamado</h1>

                <div class="row">
                    <div class="col-12 col-sm-8">
                        <div class="input-container">
                            <label for="identificacao">Identificação*</label>
                            <input id="identificacao" type="text" placeholder="Digite a identificação do equipamento" autocomplete="off">
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col">
                        <div class="row">
                            <div class="col-12 col-sm-4">
                                <div class="input-container">
                                    <label for="marca">Marca*</label>
                                    <select>
                                        <option value="Dell">Dell</option>
                                        <option value="Lenovo">Lenovo</option>
                                        <option value="Samsung">Samsung</option>
                                        <option value="Avell">Avell</option>
                                    </select>
                                </div>
                            </div>
                            <div class="col-12 col-sm-4">
                                <div class="input-container">
                                    <label for="modelo">Modelo*</label>
                                    <select id="modelo">
                                        <option value="C3P0">C3P0</option>
                                        <option value="C459">C459</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col">
                        <div class="row">
                            <div class="col-12 col-sm-4">
                                <div class="input-container">
                                    <label for="telefone">Telefone*</label>
                                    <input id="telefone" type="text" placeholder="(xx)xxxx-xxxx" autocomplete="off">
                                </div>
                            </div>
                            <div class="col-12 col-sm">
                                <div class="input-container">
                                    <label for="erro">Mensagem de erro</label>
                                    <input id="erro" type="text" placeholder="Digite a mensagem de erro" autocomplete="off">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col">
                        <div class="input-container">
                            <label for="descricao">Descrição:*</label>
                            <textarea id="descricao" rows="4" placeholder="Descreva o chamado o mais detalhado possível"></textarea>
                        </div>
                    </div>
                </div>

                <div>
                    <p class="text-muted">Campos obrigatórios(*)</p>
                </div>


                <div class="row mt-4">
                    <div class="col">
                        <label>Notificações</label>
                    </div>
                </div>
                <div>
                    <div class="custom-control custom-checkbox">
                        <input type="checkbox" class="custom-control-input" id="atualizarEmail">
                        <label class="custom-control-label" for="atualizarEmail">Ser atualizado por e-mail</label>
                    </div>
                    <div class="custom-control custom-checkbox">
                        <input type="checkbox" class="custom-control-input" id="acompanharSms">
                        <label class="custom-control-label" for="acompanharSms">Acompanhar via SMS</label>
                    </div>
                </div>
                <div class="my-2" style="padding-bottom: 100px;">
                    <button class="botao icone primary">
                        <i class="material-icons">add</i>
                        Abrir Chamado
                    </button>
                </div>


            </div>
            <div class="conteudo-anexo hide-mobile">

                <div class="row p-0">
                    <div class="px-2">
                        <i class="material-icons">attach_file</i>
                    </div>

                    <div class="col p-0">
                        <h2 class="mt-0 mb-2">Adicionar anexo</h2>
                        <p class="text-muted">Você pode enviar arquivos como evidências do problema</p>
                    </div>
                </div>

                <div class="adicionar-arquivo">
                    <div class="d-flex">
                        <div class="px-2">
                            <i class="material-icons">folder    </i>
                        </div>

                        <div class="col p-0">
                            <strong class="">Computador</strong>
                            <p class="m-0">Fazer upload atrás de uma pasta no meu computador</p>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    <script>
        $(".item-menu").eq(0).addClass("selecionado");

    </script>
</asp:Content>
