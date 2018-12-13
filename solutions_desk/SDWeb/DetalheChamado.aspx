<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="DetalheChamado.aspx.cs" Inherits="SDWeb.DetalheChamado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="sub-menu hide-mobile">
            <a href="javascript:void(0);" class="botao icone ghost" onClick="window.history.back();">
                <i class="material-icons">arrow_back</i>
                Voltar
            </a>

            <div class="lista-chamados mt-3">
                <div>
                    <strong>Chamados</strong>
                </div>

                <span class="separador"></span>

                <div>
                    <p class="m-0 text-muted">Atual</p>
                </div>
                <div class="chamado encerrado atual">
                    <p>Nº: <strong>448948</strong></p>
                    <p>Cliente: <strong>Juão Neves</strong></p>
                    <p>Aberto em: <strong>01/05/2018</strong></p>
                </div>

                <div class="mt-4">
                    <p class="m-0 text-muted">Recentes</p>
                </div>
                <div class="chamado tecnico">
                    <p>Nº: <strong>448948</strong></p>
                    <p>Cliente: <strong>Juão Neves</strong></p>
                    <p>Aberto em: <strong>01/05/2018</strong></p>
                </div>

                <div class="chamado andamento">
                    <p>Nº: <strong>448948</strong></p>
                    <p>Cliente: <strong>Juão Neves</strong></p>
                    <p>Aberto em: <strong>01/05/2018</strong></p>
                </div>
            </div>
        </div>

        <div class="conteudo conteudo-detalhe-container d-flex">
            <div class="conteudo-chamado">
                <h1 class="mt-0">Detalhe do chamado</h1>

                <div class="row">
                    <div class="col">
                        <div class="d-flex">
                            <div>
                                <h2 class="numero-chamado"><strong>D356214564</strong></h2>
                            </div>
                            <div class="col pr-0 text-right tags d-flex justify-content-end">
                                <span class="tag align-self-center">Em andamento</span>
                            </div>
                        </div>
                        <span class="barra-status andamento"></span>
                    </div>
                </div>

                <div class="mt-4">
                    <p><strong>Nome:</strong> Marcelo Machado</p>
                    <p><strong>Telefone:</strong> 11-943268693</p>
                    <p><strong>E-mail:</strong> marcelo@gmail.com</p>
                    <p><strong>Endereço:</strong> Rua das flores floridas</p>
                </div>

                <span class="separador my-4"></span>

                <div class="mb-4">
                    <p class="m-0"><strong>Mensagem de errro:</strong></p>
                    <p class="mt-0">Teclado parou de funcionar por motivos desconhecidos</p>
                </div>

                <div class="mb-4">
                    <p class="m-0"><strong>Descrição:</strong></p>
                    <p class="mt-0">Meu gato derrubou o notebook da mesa</p>
                </div>

                <div>
                    <h3>Comentários:</h3>

                    <div class="comentarios">
                        <div class="comentario">
                            <p class="m-0"><strong>Ana Júlia</strong> - <span class="text-muted">24/05/2018</span></p>
                            <p class="m-0">Solicitado ao cliente que seja anexado ao chamado uma foto</p>
                        </div>

                        <div class="comentario">
                            <p class="m-0"><strong>Ana Júlia</strong> - <span class="text-muted">24/05/2018</span></p>
                            <p class="m-0">Solicitado ao cliente que seja anexado ao chamado uma foto</p>
                        </div>
                    </div>
                </div>

                <span class="separador my-4"></span>

                <div class="my-2 text-center" style="padding-bottom: 100px;">
                    <h3>O chamado pode ser cancelado a qualquer momento</h3>
                    <button class="botao icone danger">
                        <i class="material-icons">block</i>
                        Cancelar Chamado
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
</asp:Content>
