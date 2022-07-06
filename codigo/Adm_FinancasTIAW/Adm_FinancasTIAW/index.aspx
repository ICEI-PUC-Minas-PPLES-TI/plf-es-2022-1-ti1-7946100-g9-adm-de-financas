
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
                    <li><a href="index">Home</a></li>
                    <li><a href="metas">Metas</a></li>
                    <li></li>
                    <li><a href="login">Sair</a></li>
                </ul>
            </nav>
        </div>
    </header>

    <div class="info">
       
        <div class="foto">
            <h3 id="nome"><asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label></h3>
            <img src="Content/img/blank_profile.png">
        </div>
         
            <div class="dinheiros">

                <h4>Saldo</h4>
                <p class="dinheirinho"><asp:Label ID="lblSaldo" runat="server" Text="R$0.00"></asp:Label></p>
                <br>

                <h4>Gastos no mês</h4>
                <p class="dinheirinho"><asp:Label ID="lblUltGastos" runat="server" Text="R$0.00"></asp:Label></p>
                <br>

                <h4>Metas Atingidas</h4>
                <p class="dinheirinho"><asp:Label ID="lblMetasAtingidas" runat="server" Text="0"></asp:Label></p>
                <br>
            </div>
            

        <form runat="server">
        <div class="outras-coisas">
            
            <h3><a href="#salario">   Ganho Mensal: R$</a>
                <asp:Label ID="lblGanhoMensal" runat="server" Text="0.00"></asp:Label> <asp:TextBox ID="txtGanhoMensal" runat="server" CssClass="cadastros"  Width="20%" Height="30px" TextMode="Number" AutoPostBack="true" Visible="false"></asp:TextBox>
            <asp:Button ID="btnEditarGanhoMensal" runat="server" Text="Editar" CssClass="botao" OnClick="btnEditarGanhoMensal_Click"  /></h3>
            
            <h3><a href="#contas" style="padding-right:30px">      Transporte</a> <asp:TextBox ID="txtCadTransporte" runat="server" CssClass="cadastros" TextMode="Number" Width="20%" Height="30px" AutoPostBack="true"></asp:TextBox>
            <asp:Button ID="btnCadTransporte" runat="server" Text="Adicionar" CssClass="botao" OnClick="btnCadGasto_Click"  /></h3>

            <h3><a href="#alimentacao" style="padding-right:10px">Alimentação</a><asp:TextBox ID="txtCadAlimentação" runat="server" CssClass="cadastros" TextMode="Number" Width="20%" Height="30px" AutoPostBack="true"></asp:TextBox>
            <asp:Button ID="btnCadAlimentação" runat="server" Text="Adicionar" CssClass="botao" OnClick="btnCadGasto_Click" /></h3>

            <h3><a href="#lazer" style="padding-right:80px">            Saúde</a><asp:TextBox ID="txtCadSaúde" runat="server" CssClass="cadastros" TextMode="Number" Width="20%" Height="30px" AutoPostBack="true"></asp:TextBox>
            <asp:Button ID="btnCadSaúde" runat="server" Text="Adicionar" CssClass="botao" OnClick="btnCadGasto_Click" /></h3>

            <h3><a href="#outros" style="padding-right:82px">Lazer           </a><asp:TextBox ID="txtCadLazer" runat="server" CssClass="cadastros" TextMode="Number"  Width="20%" Height="30px" AutoPostBack="true"></asp:TextBox>
            <asp:Button ID="btnCadLazer" runat="server" Text="Adicionar" CssClass="botao" OnClick="btnCadGasto_Click" /></h3>

            <h3><a href="#outros"style="padding-right:30px">Educação        </a><asp:TextBox ID="txtCadEducação" runat="server" CssClass="cadastros" TextMode="Number" Width="20%" Height="30px" AutoPostBack="true"></asp:TextBox>
            <asp:Button ID="btnCadEducação" runat="server" Text="Adicionar" CssClass="botao" OnClick="btnCadGasto_Click" /></h3>

            <h3><a href="#outros" style="padding-right:62px">Outros          </a><asp:TextBox ID="txtCadOutros" runat="server" CssClass="cadastros" TextMode="Number" Width="20%" Height="30px" AutoPostBack="true"></asp:TextBox>
            <asp:Button ID="btnCadOutros" runat="server" Text="Adicionar" CssClass="botao" OnClick="btnCadGasto_Click" /></h3>

        </div>
            </form>
    </div>



    <footer>
    </footer>

</body>
</html>
