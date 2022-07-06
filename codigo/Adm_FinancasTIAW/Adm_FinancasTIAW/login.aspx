<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

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
                    <li><a href="cadastro">Cadastre-se</a></li>
                </ul>
            </nav>
        </div>
    </header>
    <div class="login">
        <form class="modal-content animate" onreset="login()" runat="server">
            <div class="imgcontainer">
                <p align="center">
                    <img src="https://www.w3schools.com/howto/img_avatar2.png" alt="Avatar" class="avatar">
                </p>
            </div>

            <div class="container">
                <label for="txtEmail"><b>Email</b></label>
                <asp:TextBox ID="txtEmail" runat="server"  placeholder="Digite o Email" required></asp:TextBox>
                <label for="txtPsw"><b>Senha</b></label>
                <asp:TextBox ID="txtPsw" runat="server"  placeholder="Digite a Senha"  required TextMode="Password"></asp:TextBox>

                <asp:Button ID="btnSubmit" runat="server" Text="Login" OnClick="btnSubmit_Click" CssClass="botao"/><br/>
                <asp:Label ID="lblRetorno" runat="server" Text="" ForeColor="Red"></asp:Label>
            </div>

            <div class="container" style="background-color:#f1f1f1">
                <span class="psw">Esqueceu sua <a href="#">Senha?</a></span>
            </div>
        </form>
</div>


    <footer>
    </footer>

</body>
</html>
