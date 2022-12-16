<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormLogin.aspx.cs" Inherits="RyL.WebFormLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous"/>
    <link rel="stylesheet" href="css/estilo.css" type="text/css" />
    <link rel="icon" type="image/x-icon" href="/img/site/favicon.ico" />
    <title>R&L Impresos</title>
</head>
<body class="body login">
    <div class="cajaLogin">
        <img src="img/site/logo.png" class="logo" alt="R&L" />
        <form id="form1" runat="server">
            <h1 style="text-align: center;">Bienvenido</h1>
            <div class="row mb-3">
                <div class="col-12">
                    <label for="TextBoxUsuario">Usuario:</label>
                    <asp:TextBox ID="TextBoxUsuario" class="form-control" runat="server" required></asp:TextBox>
                </div>
            </div>
            <div class="row mb-3">
                <div class="col-12">
                    <label for="TextBoxClave">Clave:</label>
                    <asp:TextBox ID="TextBoxClave" class="form-control" runat="server" TextMode="Password" required></asp:TextBox>
                </div>
            </div>

            <div class="row mb-3">
                <div class="d-grid gap-2">
                    <asp:RadioButtonList ID="RadioButtonListTipoUsuario" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1">Empleado</asp:ListItem>
                        <asp:ListItem Value="2">Administrador</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>

            <div class="row mb-3">
                <div class="d-grid gap-2">
                    <asp:Button ID="ButtonLogin" class="btn btn-primary" runat="server" OnClick="ButtonLogin_Click" Text="Iniciar Sesion"  />
                </div>
            </div>
             <div class="row">
            <div class="col">
                <asp:Label ID="LabelMensaje" runat="server"></asp:Label>
            </div>
        </div>
        </form>
    </div>

    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.3/dist/umd/popper.min.js" integrity="sha384-eMNCOe7tC1doHpGoWe/6oMVemdAVTMs2xqW4mwXrXsW0L84Iytr2wi5v2QjrP/xp" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.min.js" integrity="sha384-cn7l7gDp0eyniUwwAZgrzD06kc/tftFf19TOAs2zVinnD/C7E91j9yyk5//jjpt/" crossorigin="anonymous"></script>
</body>
</html>
