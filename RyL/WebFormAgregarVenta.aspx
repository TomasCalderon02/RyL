<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAgregarVenta.aspx.cs" Inherits="RyL.WebFormAgregarVenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="icon" type="image/x-icon" href="/img/site/favicon.ico" />

    <link rel="stylesheet" href="css/estilo.css" type="text/css" />
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Fira+Sans&display=swap" rel="stylesheet" />

    <link href="css/styles.css" rel="stylesheet" />

    <script src="https://use.fontawesome.com/releases/v6.1.0/js/all.js" crossorigin="anonymous"></script>

    <script src="js/scripts.js"></script>

    <title>R&L Impresos</title>
</head>
<body class="fondo sb-nav-fixed">
    <!--Barra superior navbar-->
    <div class="container-fluid">
        <nav class="sb-topnav navbar navbar-expand-lg navbar-dark bg-dark">
            <!-- Navbar Brand-->
            <a class="navbar-brand ps-3">
                <img src="/img/site/logo.png" alt="" width="" height="40" class="d-inline-block"/></a>

            <!-- Sidebar Toggle-->
            <button class="btn btn-link btn-sm order-1 order-lg-0 me-4 me-lg-0" id="sidebarToggle" href="#!"><i class="fas fa-bars"></i></button>

            <!-- Navbar-->
            <form class="d-none d-md-inline-block form-inline ms-auto me-0 me-md-3 my-2 my-md-0">
            </form>

        </nav>
    </div>

    <!--Fin barra superior-->

    <div id="layoutSidenav">
        <!-- Barra Lateral -->
        <div id="layoutSidenav_nav">
            <nav class="sb-sidenav accordion sb-sidenav-dark" id="sidenavAccordion">
                <div class="sb-sidenav-menu">
                    <div class="nav">

                        <!--Inicio datos sesion-->
                        <div class="sb-sidenav-menu-heading">Perfil</div>

                        <a class="nav-link">
                            <div class="sb-nav-link-icon">
                                <i class="fa-solid fa-user"></i>
                            </div>
                            Usuario:&nbsp;
                                <strong>
                                    <asp:Label ID="LabelUsuario" runat="server"></asp:Label>
                                </strong>
                        </a>

                        <a class="nav-link" href="WebFormFinSesion.aspx">
                            <div class="sb-nav-link-icon">
                                <i class="fa-solid fa-right-from-bracket"></i>
                            </div>
                            Cerrar Sesión
                        </a>
                        <!--Fin datos sesion-->
                        <div class="sb-sidenav-menu-heading">Gestión</div>
                        <!-- Opcion Dashboard -->

                        <a runat="server" id="dashboard" class="nav-link" href="WebFormDashboard.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-tachometer-alt"></i></div>
                            Dashboard
                        </a>

                        <!-- Fin Opcion Dashboard -->
                        <!-- Opcion OTs -->
                        <a class="nav-link collapsed" href="#" data-bs-toggle="collapse" data-bs-target="#collapseOT" aria-expanded="false" aria-controls="collapseOT">
                            <div class="sb-nav-link-icon"><i class="fa-solid fa-briefcase"></i></div>
                            Ordenes de Trabajo
                                <div class="sb-sidenav-collapse-arrow"><i class="fas fa-angle-down"></i></div>
                        </a>

                        <div class="collapse" id="collapseOT" aria-labelledby="headingOne" data-bs-parent="#sidenavAccordionOT">
                            <nav class="sb-sidenav-menu-nested nav">
                                <a class="nav-link" href="WebFormAgregar.aspx">Nueva Orden de Trabajo</a>
                            </nav>
                        </div>

                        <div class="collapse" id="collapseOT" aria-labelledby="headingOne" data-bs-parent="#sidenavAccordionOT">
                            <nav class="sb-sidenav-menu-nested nav">
                                <a class="nav-link" href="WebFormListar.aspx">Todas las OT</a>
                            </nav>
                        </div>

                        <div class="collapse" id="collapseOT" aria-labelledby="headingOne" data-bs-parent="#sidenavAccordionOT">
                            <nav class="sb-sidenav-menu-nested nav">
                                <a class="nav-link" href="WebFormFiltro.aspx">OTs por filtro</a>
                            </nav>
                        </div>
                        <!-- Fin Opcion OTs -->
                        <!-- Opcion Ventas -->
                        <a class="nav-link collapsed" id="ventas" runat="server" href="#" data-bs-toggle="collapse" data-bs-target="#collapseVentas" aria-expanded="false" aria-controls="collapseVentas">
                            <div class="sb-nav-link-icon"><i class="fa-regular fa-rectangle-list"></i></div>
                            Ventas
                                <div class="sb-sidenav-collapse-arrow"><i class="fas fa-angle-down"></i></div>
                        </a>
                        <div class="collapse" id="collapseVentas" aria-labelledby="headingOne" data-bs-parent="#sidenavAccordionVentas">
                            <nav class="sb-sidenav-menu-nested nav">
                                <a runat="server" class="nav-link" href="WebFormAgregarVenta.aspx">Nueva Venta</a>
                            </nav>
                        </div>

                        <div class="collapse" id="collapseVentas" aria-labelledby="headingOne" data-bs-parent="#sidenavAccordionVentas">
                            <nav class="sb-sidenav-menu-nested nav">
                                <a runat="server" class="nav-link" href="WebFormListarVentas.aspx">Libro de Ventas</a>
                            </nav>
                        </div>
                        <!-- Fin Opcion Ventas -->
                        <!-- Opcion Cobranza -->
                        <a class="nav-link collapsed" id="cobranza" runat="server" href="#" data-bs-toggle="collapse" data-bs-target="#collapseCob" aria-expanded="false" aria-controls="collapseCob">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Cobranza
                                <div class="sb-sidenav-collapse-arrow"><i class="fas fa-angle-down"></i></div>
                        </a>
                        <div class="collapse" id="collapseCob" aria-labelledby="headingOne" data-bs-parent="#sidenavAccordionCob">
                            <nav class="sb-sidenav-menu-nested nav">
                                <a class="nav-link" href="WebFormAgregarCobranza.aspx">Nueva Cobranza</a>
                            </nav>
                        </div>
                        <div class="collapse" id="collapseCob" aria-labelledby="headingOne" data-bs-parent="#sidenavAccordionCob">
                            <nav class="sb-sidenav-menu-nested nav">
                                <a class="nav-link" href="WebFormListarCobranza.aspx">Libro de Cobranzas</a>
                            </nav>
                        </div>
                    </div>
                </div>

                <div class="sb-sidenav-footer">
                </div>
            </nav>
        </div>
        <!-- Fin Barra Lateral -->

        <div id="layoutSidenav_content">
            <main>
                <div class="cajaForm">
                    <form id="form1" runat="server">
                        <h1>Ventas</h1>
                        <div class="row mb-3">
                            <div class="col">
                                <asp:Label ID="LabelMensaje" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="row mb-3">
                            <div class="col">
                                <label for="TextBoxID" class="form-label">ID:</label>
                                <asp:TextBox ID="TextBoxID" class="form-control" runat="server" TextMode="Number" required ReadOnly></asp:TextBox>
                            </div>
                        </div>
                        <div class="row mb-3">
                            <div class="col">
                                <label for="DropDownListDoc" class="form-label">Doc:</label>
                                <asp:DropDownList ID="DropDownListDoc" runat="server" class="form-select" aria-label="Default select example" required>
                                    <asp:ListItem Value="33">Factura Electrónica</asp:ListItem>
                                    <asp:ListItem Value="35">Boleta</asp:ListItem>
                                    <asp:ListItem Value="61">Nota de Crédito Electrónica</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="row mb-3">
                            <div class="col">
                                <label for="TextBoxRutCliente" class="form-label">RUT del Cliente:</label>
                                <asp:TextBox ID="TextBoxRutCliente" class="form-control" runat="server" required></asp:TextBox>
                            </div>
                        </div>
                        <div class="row mb-3">
                            <div class="col">
                                <label for="TextBoxRazonSocial" class="form-label">Razon Social:</label>
                                <asp:TextBox ID="TextBoxRazonSocial" class="form-control" runat="server" required></asp:TextBox>
                            </div>
                        </div>
                        <div class="row mb-3">
                            <div class="col">
                                <label for="TextBoxFolio" class="form-label">Folio:</label>
                                <asp:TextBox ID="TextBoxFolio" class="form-control" runat="server" required></asp:TextBox>
                            </div>
                        </div>
                        <div class="row mb-3">
                            <div class="col">
                                <label for="TextBoxFechaDocto" class="form-label">Fecha Docto:</label>
                                <asp:TextBox ID="TextBoxFechaDocto" class="form-control" runat="server" TextMode="Date" required></asp:TextBox>
                            </div>
                        </div>
                        <div class="row mb-3">
                            <div class="col">
                                <label for="TextBoxMontoTotal" class="form-label">Monto Total:</label>
                                <asp:TextBox ID="TextBoxMontoTotal" class="form-control" runat="server" TextMode="Number" required></asp:TextBox>
                            </div>
                        </div>
                        <div class="row mb-3">
                            <div class="col">
                                <label for="TextBoxFechaPago" class="form-label">Fecha de Pago:</label>
                                <asp:TextBox ID="TextBoxFechaPago" class="form-control" runat="server" TextMode="Date" required></asp:TextBox>
                            </div>
                        </div>
                        <div class="row mb-3">
                            <div class="col">
                                <label for="TextBoxVendedor" class="form-label">Vendedor:</label>
                                <asp:TextBox ID="TextBoxVendedor" class="form-control" runat="server" required></asp:TextBox>
                            </div>
                        </div>
                        <div class="row mb-3">
                            <div class="d-grid gap-2">
                                <asp:Button ID="ButtonAgregar" class="btn btn-primary" runat="server" OnClick="ButtonAgregar_Click" Text="Agregar" />
                            </div>
                        </div>
                    </form>
                </div>
            </main>
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.min.js" integrity="sha384-cn7l7gDp0eyniUwwAZgrzD06kc/tftFf19TOAs2zVinnD/C7E91j9yyk5//jjpt/" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/simple-datatables@latest" crossorigin="anonymous"></script>
</body>
</html>
