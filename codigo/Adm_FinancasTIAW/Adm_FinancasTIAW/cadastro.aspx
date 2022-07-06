<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cadastro.aspx.cs" Inherits="cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
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
                    <li><a href="login">Login</a></li>
                </ul>
            </nav>
        </div>
    </header>
    <div class="login">
        <form class="modal-content animate" runat="server">
            <div class="imgcontainer">
                <p align="center">
                    <img src="https://www.w3schools.com/howto/img_avatar2.png" alt="Avatar" class="avatar">
                </p>
            </div>

            <div class="container">
                <label for="txtEmail"><b>Email</b></label>
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Digite seu Email" required="required"></asp:TextBox>
                
                <label for="txtNome"><b>Nome</b></label>
                <asp:TextBox ID="txtNome" runat="server" placeholder="Digite seu Nome" required="required"></asp:TextBox>

                <label for="txtPsw"><b>Senha</b></label>
                <asp:TextBox ID="txtPsw" runat="server" placeholder="Digite sua Senha" required="required" TextMode="Password"></asp:TextBox>

                <label for="txtPsw2"><b>Repetir Senha</b></label>
                <asp:TextBox ID="txtPsw2" runat="server" placeholder="Repita sua Senha" required="required" TextMode="Password"></asp:TextBox>

                <asp:Button ID="btnSubmit" runat="server" Text="Cadastrar" OnClick="btnSubmit_Click" CssClass="botao"/><br/>
                <asp:Label ID="lblRetorno" runat="server" Text="" ForeColor="Red" style="text-align:center"></asp:Label>
            </div>

            <div class="container" style="background-color:#f1f1f1">
                <span class="psw">Já está cadastrado?<a href="login.html">Faça Login</a></span>
            </div>
        </form>
    </div>


    <footer>
    </footer>

</body>
</html>
