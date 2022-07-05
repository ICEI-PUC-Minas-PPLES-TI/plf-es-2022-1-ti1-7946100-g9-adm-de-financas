﻿
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" type="text/css" href="Content/css/css.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;300;400&display=swap" rel="stylesheet">
    <title></title>
</head>
<body>

    <header class="menu-bg">
        <div class="menu">
            <div class="menu-logo">
                <a href="#"></a>
            </div>
            <nav class="menu-nav">
                <ul>
                    <li><a href="#home">Home</a></li>
                    <li><a href="#noticias">Notícias</a></li>
                    <li><a href="#metas">Metas</a></li>
                    <li></li>
                    <li><a href="#" onclick="sair()">Sair</a></li>
                </ul>
            </nav>
        </div>
    </header>

    <div class="info">
       
        <div class="foto">
            <h3 id="nome"><asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label></h3>
            <img src="Content/img/blank_profile.png">
        </div>
         <form runat="server">
            <div class="dinheiros">
                <h4>Saldo</h4>
                <p class="dinheirinho"><asp:Label ID="lblSaldo" runat="server" Text="R$0.00"></asp:Label></p>
                <br>

                <h4>Últimos gastos</h4>
                <p class="dinheirinho"><asp:Label ID="lblUltGastos" runat="server" Text="R$0.00"></asp:Label></p>
                <br>

                <h4>Últimos lucros</h4>
                <p class="dinheirinho"><asp:Label ID="lblUltLucros" runat="server" Text="R$0.00"></asp:Label></p>
                <br>
            </div>
            </form>
        <div class="outras-coisas">
            <h3><a href="#salario">Salário</a></h3>

            <h3><a href="#contas">Contas</a></h3>

            <h3><a href="#alimentacao">Alimentação</a></h3>

            <h3><a href="#lazer">Lazer</a></h3>

            <h3><a href="#outros">Outros</a></h3>

        </div>
            
    </div>



    <footer>
    </footer>

</body>
</html>