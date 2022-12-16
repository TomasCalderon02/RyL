<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormVer.aspx.cs" Inherits="RyL.WebFormVer" %>

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

    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.0/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body class="fondo sb-nav-fixed">
    <!--Barra superior navbar-->
    <div class="container-fluid">
        <nav class="sb-topnav navbar navbar-expand-lg navbar-dark bg-dark">
            <!-- Navbar Brand-->
            <a class="navbar-brand ps-3">
                <img src="/img/site/logo.png" alt="" width="" height="40" class="d-inline-block" /></a>

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
                        <h1>Orden de Trabajo</h1>
                        <fieldset>
                            <div class="row mb-3">
                                <div class="col-12">
                                    <label for="TextBoxID" class="form-label">ID:</label>
                                    <asp:TextBox ID="TextBoxID" class="form-control" runat="server" TextMode="Number" ReadOnly></asp:TextBox>
                                </div>
                            </div>
                            <div class="row mb-3">
                                <div class="col">
                                    <label for="TextBoxFechaIngreso" class="form-label">Fecha de Ingreso:</label>
                                    <asp:TextBox ID="TextBoxFechaIngreso" class="form-control" runat="server" TextMode="Date" ReadOnly></asp:TextBox>
                                </div>
                                <div class="col">
                                    <label for="TextBoxFechaEntrega" class="form-label">Fecha de Entrega:</label>
                                    <asp:TextBox ID="TextBoxFechaEntrega" class="form-control" runat="server" TextMode="Date" ReadOnly></asp:TextBox>
                                </div>
                            </div>
                            <div class="row mb-3">
                                <div class="col">
                                    <label for="TextBoxCliente" class="form-label">RUT del Cliente:</label>
                                    <asp:TextBox ID="TextBoxCliente" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                                <div class="col">
                                    <label for="TextBoxTrabajo" class="form-label">Trabajo:</label>
                                    <asp:TextBox ID="TextBoxTrabajo" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                            </div>
                            <div class="row mb-3">
                                <div class="col">
                                    <label for="TextBoxReimpresion" class="form-label">Reimpresion OT:</label>
                                    <asp:TextBox ID="TextBoxReimpresion" class="form-control" runat="server" TextMode="Number" ReadOnly></asp:TextBox>
                                </div>
                                <div class="col">
                                    <label for="TextBoxCantidad" class="form-label">Cantidad:</label>
                                    <asp:TextBox ID="TextBoxCantidad" class="form-control" runat="server" TextMode="Number" ReadOnly></asp:TextBox>
                                </div>
                            </div>
                            <div class="row mb-3">
                                <div class="col">
                                    <label for="TextBoxCotizacion" class="form-label">Cotizacion N°:</label>
                                    <asp:TextBox ID="TextBoxCotizacion" class="form-control" runat="server" TextMode="Number" ReadOnly></asp:TextBox>
                                </div>
                                <div class="col">
                                    <label for="TextBoxPapel" class="form-label">Papel:</label>
                                    <asp:TextBox ID="TextBoxPapel" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                            </div>
                            <div class="row mb-3">
                                <div class="col">
                                    <label for="TextBoxCantPliegos" class="form-label">Cant. de Pliegos:</label>
                                    <asp:TextBox ID="TextBoxCantPliegos" class="form-control" runat="server" TextMode="Number" ReadOnly></asp:TextBox>
                                </div>
                                <div class="col">
                                    <label for="TextBoxFormato" class="form-label">Formato:</label>
                                    <asp:TextBox ID="TextBoxFormato" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                                <div class="col">
                                    <label for="TextBoxTamanoArticulo" class="form-label">Tamaño Articulo:</label>
                                    <asp:TextBox ID="TextBoxTamanoArticulo" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                            </div>
                            <div class="row mb-3">
                                <div class="col">
                                    <label for="TextBoxTerminado" class="form-label">Terminado:</label>
                                    <asp:TextBox ID="TextBoxTerminado" class="form-control" runat="server" TextMode="Date" ReadOnly></asp:TextBox>
                                </div>
                                <div class="col">
                                    <label for="TextBoxFactN" class="form-label">Fact N°:</label>
                                    <asp:TextBox ID="TextBoxFactN" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                                <div class="col">
                                    <label for="TextBoxGuiaN" class="form-label">Guia N°:</label>
                                    <asp:TextBox ID="TextBoxGuiaN" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                            </div>
                        </fieldset>
                        <fieldset>
                            <h2>Preprensa</h2>
                            <div class="row mb-3">
                                <div class="col">
                                    <div class="form-check">
                                        <label for="RadioButtonListPruebaColor" class="form-label">Prueba de Color:</label>
                                        <asp:RadioButtonList ID="RadioButtonListPruebaColor" runat="server">
                                            <asp:ListItem Value="0" Enabled="False" Selected="True">Si</asp:ListItem>
                                            <asp:ListItem Value="1" Enabled="False">No</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                                </div>
                                <div class="col">
                                    <div class="form-check">
                                        <label for="RadioButtonListMaqueta" class="form-label">Maqueta:</label>
                                        <asp:RadioButtonList ID="RadioButtonListMaqueta" runat="server">
                                            <asp:ListItem Value="0" Enabled="False">Si</asp:ListItem>
                                            <asp:ListItem Value="1" Enabled="False">No</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                                </div>
                            </div>
                            <div class="row mb-3">
                                <div class="col">
                                    <label for="ImageMontaje" class="form-label">Montaje: </label>
                                    <asp:Image ID="ImageMontaje" runat="server" class="img-thumbnail" />
                                </div>
                            </div>
                            <div class="row mb-3">
                                <div class="col">
                                    <label for="TextBoxNota" class="form-label">Nota:</label>
                                    <asp:TextBox ID="TextBoxNota" class="form-control" runat="server" TextMode="MultiLine" ReadOnly></asp:TextBox>
                                </div>
                            </div>
                        </fieldset>
                        <fieldset>
                            <h2>Corte</h2>
                            <div class="row mb-3">
                                <div class="col">
                                    <label for="TextBoxTamanoPapel" class="form-label">Tamaño de Papel:</label>
                                    <asp:TextBox ID="TextBoxTamanoPapel" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                                <div class="col">
                                    <label for="TextBoxTamanoTerminado" class="form-label">Tamaño Terminado:</label>
                                    <asp:TextBox ID="TextBoxTamanoTerminado" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                            </div>
                            <div class="row mb-3">
                                <div class="col">
                                    <label for="TextBoxTiraje" class="form-label">Tiraje:</label>
                                    <asp:TextBox ID="TextBoxTiraje" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                                <div class="col">
                                    <label for="TextBoxSobrante" class="form-label">Sobrante:</label>
                                    <asp:TextBox ID="TextBoxSobrante" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                                <div class="col">
                                    <label for="TextBoxOriginal" class="form-label">Original:</label>
                                    <asp:TextBox ID="TextBoxOriginal" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                            </div>
                            <div class="row mb-3">
                                <div class="col">
                                    <label for="TextBoxCopia" class="form-label">Copia:</label>
                                    <asp:TextBox ID="TextBoxCopia" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                            </div>
                        </fieldset>
                        <fieldset>
                            <h2>Prensa</h2>
                            <div class="row mb-3">
                                <div class="col">
                                    <label for="DropDownListMaquina" class="form-label">Maquina:</label>
                                    <asp:DropDownList ID="DropDownListMaquina" runat="server" class="form-select" aria-label="Default select example" disabled>
                                    </asp:DropDownList>
                                </div>
                                <div class="col">
                                    <label for="TextBoxTercero" class="form-label">Tercero:</label>
                                    <asp:TextBox ID="TextBoxTercero" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                            </div>
                            <div class="row mb-3">
                                <div class="col">
                                    <label for="TextBoxTinta" class="form-label">Tinta:</label>
                                    <asp:TextBox ID="TextBoxTinta" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                                <div class="col">
                                    <label for="TextBoxTiro:" class="form-label">Tiro:</label>
                                    <asp:TextBox ID="TextBoxTiro" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                                <div class="col">
                                    <label for="TextBoxRetiro" class="form-label">Retiro:</label>
                                    <asp:TextBox ID="TextBoxRetiro" class="form-control" runat="server" ReadOnly></asp:TextBox>
                                </div>
                            </div>
                            <div class="row mb-3">
                                <div class="col">
                                    <div class="form-check">
                                        <label for="RadioButtonListBarnizO" class="form-label">Barniz Opaco:</label>
                                        <asp:RadioButtonList ID="RadioButtonListBarnizO" runat="server">
                                            <asp:ListItem Value="0" Enabled="False">Tiro</asp:ListItem>
                                            <asp:ListItem Value="1" Enabled="False">Retiro</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                                </div>
                                <div class="col">
                                    <div class="form-check">
                                        <label for="RadioButtonListBarnizB" class="form-label">Barniz Brillante:</label>
                                        <asp:RadioButtonList ID="RadioButtonListBarnizB" runat="server">
                                            <asp:ListItem Value="0" Enabled="False">Tiro</asp:ListItem>
                                            <asp:ListItem Value="1" Enabled="False">Retiro</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                                </div>
                            </div>
                        </fieldset>
                        <fieldset>
                            <h2>Terminacion</h2>
                            <div class="row mb-3">
                                <asp:RadioButtonList ID="RadioButtonListTerminacion1" runat="server" RepeatColumns="4" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="0" Enabled="False">Block</asp:ListItem>
                                    <asp:ListItem Value="1" Enabled="False">Talonarios</asp:ListItem>
                                    <asp:ListItem Value="2" Enabled="False">Fajos</asp:ListItem>
                                    <asp:ListItem Value="3" Enabled="False">Otros</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                            <div class="row mb-3">
                                <asp:CheckBoxList ID="CheckBoxListTerminacion2" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="0" Enabled="False">Entapado Cabeza</asp:ListItem>
                                    <asp:ListItem Value="1" Enabled="False">Lateral</asp:ListItem>
                                    <asp:ListItem Value="2" Enabled="False">Encolado</asp:ListItem>
                                </asp:CheckBoxList>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <label for="TextBoxFolio" class="form-label">Folio:</label>
                                    <asp:TextBox ID="TextBoxFolio" class="form-control" runat="server" TextMode="Number" ReadOnly></asp:TextBox>
                                </div>
                            </div>
                        </fieldset>
                        <fieldset>
                            <h2>Externos</h2>
                            <div class="row mb-3">
                                <div class="col">
                                    <label for="TextBoxObs" class="form-label">Observaciones:</label>
                                    <asp:TextBox ID="TextBoxObs" class="form-control" runat="server" TextMode="MultiLine" ReadOnly></asp:TextBox>
                                </div>
                            </div>
                            <div class="row mb-3">
                                <asp:RadioButtonList ID="RadioButtonListEstado" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="0" Enabled="False">Pendiente</asp:ListItem>
                                    <asp:ListItem Value="1" Enabled="False">Terminado</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                        </fieldset>
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
