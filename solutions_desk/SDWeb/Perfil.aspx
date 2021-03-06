﻿<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="SDWeb.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="sub-menu hide-mobile">
            <a href="javascript:void(0);" class="sub-menu-item">
                <i class="material-icons">person</i>
                Perfil
            </a>
        </div>

        <div class="conteudo conteudo-detalhe-container d-flex">
            <div class="conteudo-chamado">
                <h1 class="mt-0">Jorge Santos</h1>

                <div class="row">
                    <div class="col-12 col-sm-8">
                        <div class="input-container">
                            <label for="nome">Nome*</label>
                            <input id="nome" type="text" placeholder="Nome completo" autocomplete="off">
                        </div>
                    </div>
                    <div class="col">
                        <div class="input-container">
                            <label for="nome">CPF*</label>
                            <input id="nome" type="text" placeholder="________-__" autocomplete="off">
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col">
                        <div class="row">
                            <div class="col-12 col-sm-4">
                                <div class="input-container">
                                    <label for="telefone">Telefone*</label>
                                    <input id="telefone" type="text" placeholder="(xx)xxxx-xxxx">
                                </div>
                            </div>
                            <div class="col">
                                <div class="input-container">
                                    <label for="erro">E-mail</label>
                                    <input id="erro" type="text" placeholder="exemplo@com.br">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col">
                        <div class="row">
                            <div class="col-12 col-sm-3">
                                <div class="input-container">
                                    <label for="marca">CEP*</label>
                                    <input placeholder="_____-___">
                                </div>
                            </div>
                            <div class="col-12 col-sm-6">
                                <div class="input-container">
                                    <label for="modelo">Endereço*</label>
                                    <input placeholder="Rua, Av, Viela">
                                </div>
                            </div>
                            <div class="col">
                                <div class="input-container">
                                    <label for="modelo">Número*</label>
                                    <input placeholder="0000">
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
                                    <label for="bairro">Bairro*</label>
                                    <input id="bairro" type="text">
                                </div>
                            </div>
                            <div class="col-12 col-sm-5">
                                <div class="input-container">
                                    <label for="cidade">Cidade*</label>
                                    <input id="cidade" type="text">
                                </div>
                            </div>
                            <div class="col-12 col-sm-3">
                                <div class="input-container">
                                    <label for="erro">Estado*</label>
                                    <select>
                                        <option value="SP">SP</option>
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
                                    <label for="bairro">Senha*</label>
                                    <input id="bairro" type="text">
                                </div>
                            </div>
                            <div class="col-12 col-sm-4">
                                <div class="input-container">
                                    <label for="cidade">Confirmar Senha*</label>
                                    <input id="cidade" type="text">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div>
                    <p class="text-muted">Campos obrigatórios(*)</p>
                </div>


                <div class="my-2" style="padding-bottom: 100px;">
                    <div class="row">
                        <div class="col-12 col-sm-9">
                            <button class="botao block icone danger">
                                <i class="material-icons">delete</i>
                                Excluir Cadastro
                            </button>
                        </div>
                        <div class="col-12 text-right">
                            <button class="botao block primary">
                                Salvar
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    <script>
        $(".item-menu").eq(2).addClass("selecionado");

    </script>
</asp:Content>
