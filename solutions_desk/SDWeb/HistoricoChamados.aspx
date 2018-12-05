<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="HistoricoChamados.aspx.cs" Inherits="SDWeb.HistoricoChamados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="conteudo full d-flex">
        <div class="conteudo-historico-chamado">
            <h1 class="mt-0">Histórico de chamados</h1>

            <div class="row">
                <div class="col">
                    <div class="d-flex">
                        <div class="input-container">
                            <label for="id">ID</label>
                            <input id="id" type="text" placeholder="Digite o ID">
                        </div>

                        <div class="input-container ml-3">
                            <label for="cliente">Cliente</label>
                            <input id="cliente" type="text" placeholder="Nome do cliente">
                        </div>

                        <div class="input-container ml-3">
                            <label for="id">Tags/Incidentes</label>
                            <input id="id" type="text" placeholder="Digite o ID">
                        </div>

                        <div class="container-pesquisar align-self-end">
                            <button class="btn">
                                <i class="material-icons">search</i>
                            </button>
                        </div>
                    </div>
                </div>
            </div>

            <span class="separador"></span>

            <div class="legenda">
                <span class="aberto">Aberto</span>
                <span class="encerrado">Encerrado</span>
                <span class="tecnico">Em processo técnico</span>
                <span class="andamento">Em andamento</span>
                <span class="atraso">Em atraso</span>
                <span class="cancelado">Cancelado</span>
            </div>
            <div class="row">
                <div class="lista-chamados d-flex">
                   <div class="chamado encerrado" onclick="location.href='/detalheChamado.aspx';">
                        <div class="d-flex">
                            <div>
                                <span>Alice severo</span>
                            </div>
                            <div class="col text-right m-0 tags">
                                <span class="tag">312</span>
                            </div>
                        </div>

                        <div class="mt-3">
                            <p>Tags</p>
                            <div class="tags">
                                <span class="tag">Touchpad</span>
                                <span class="tag">Teclado</span>
                                <span class="tag">Monitor</span>
                            </div>
                        </div>

                        <div class="mt-3">
                            <p>Data</p>
                            <p>07/05/2018</small>
                        </div>
                     </div>
                    <div class="chamado encerrado" onclick="location.href='/detalheChamado.aspx';">
                        <div class="d-flex">
                            <div>
                                <span>Alice severo</span>
                            </div>
                            <div class="col text-right m-0 tags">
                                <span class="tag">312</span>
                            </div>
                        </div>

                        <div class="mt-3">
                            <p>Tags</p>
                            <div class="tags">
                                <span class="tag">Touchpad</span>
                                <span class="tag">Teclado</span>
                                <span class="tag">Monitor</span>
                            </div>
                        </div>

                        <div class="mt-3">
                            <p>Data</p>
                            <p>07/05/2018</small>
                        </div>
                    </div>

                </div>
            </div>

            <div class="pagination d-flex justify-content-end">
                <nav aria-label="Page navigation example">
                    <ul class="pagination">
                        <li class="page-item"><a class="page-link" href="#">Anterior</a></li>
                        <li class="page-item"><a class="page-link" href="#">1</a></li>
                        <li class="page-item"><a class="page-link" href="#">2</a></li>
                        <li class="page-item"><a class="page-link" href="#">3</a></li>
                        <li class="page-item"><a class="page-link" href="#">Próximo</a></li>
                    </ul>
                </nav>
            </div>
        </div>
    </div>
     <script>
        $(".item-menu").eq(1).addClass("selecionado");

    </script>
</asp:Content>
