using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using modelo;
using dao;
using System.Data.SqlClient;
using System.Data;

namespace RyL
{
    public partial class WebFormModificar : System.Web.UI.Page
    {
        private int id;
        private admin ad;
        private empleado emp;
        private int empOG;
        private int adOG;
        protected void Page_Load(object sender, EventArgs e)
        {
            ad = (admin)Session["admin"];
            emp = (empleado)Session["empleado"];

            if (ad != null)
            {
                LabelUsuario.Text = ad.Nombres;
            }
            else if (emp != null)
            {
                LabelUsuario.Text = emp.Nombres;
                dashboard.Visible = false;
                ventas.Visible = false;
                cobranza.Visible = false;
            }
            else
            {
                Response.Redirect("WebFormFinSesion.aspx");
            }

            if (IsPostBack == false)
                {
                    id = int.Parse(Request.QueryString.Get("id"));

                    ordenTrabajo ot = ordenTrabajoDAO.buscar(id);
                    empOG = ot.EmpID;
                    adOG = ot.AdID;

                    TextBoxEMP.Text = empOG.ToString();
                    TextBoxAD.Text = adOG.ToString();

                    TextBoxID.Text = ot.Id.ToString();
                    TextBoxFechaIngreso.Text = Convert.ToDateTime(ot.FechaIngreso).Date.ToString("yyyy-MM-dd");
                    TextBoxFechaEntrega.Text = Convert.ToDateTime(ot.FechaEntrega).Date.ToString("yyyy-MM-dd");
                    TextBoxCliente.Text = ot.Cliente;
                    TextBoxTrabajo.Text = ot.Trabajo;
                    TextBoxReimpresion.Text = ot.ReimpresionOT.ToString();
                    TextBoxCantidad.Text = ot.Cantidad.ToString();
                    TextBoxCotizacion.Text = ot.Cotizacion.ToString();
                    TextBoxPapel.Text = ot.Papel;
                    TextBoxCantPliegos.Text = ot.CantPliegos.ToString();
                    TextBoxFormato.Text = ot.Formato;
                    TextBoxTamanoArticulo.Text = ot.TamanoArticulo;
                    TextBoxTerminado.Text = Convert.ToDateTime(ot.FechaTermino).Date.ToString("yyyy-MM-dd");
                    TextBoxFactN.Text = ot.FactN;
                    TextBoxGuiaN.Text = ot.GuiaN;
                    RadioButtonListPruebaColor.SelectedValue = ot.PruebaColor.ToString();
                    RadioButtonListMaqueta.SelectedValue = ot.Maqueta.ToString();
                    TextBoxMontaje.Text = ot.Montaje;
                    TextBoxNota.Text = ot.Nota;
                    TextBoxTamanoPapel.Text = ot.TamanoPapel;
                    TextBoxTamanoTerminado.Text = ot.TamanoTerminado;
                    TextBoxTiraje.Text = ot.Tiraje;
                    TextBoxSobrante.Text = ot.Sobrante;
                    TextBoxOriginal.Text = ot.Original;
                    TextBoxCopia.Text = ot.Copia;
                    DropDownListMaquina.SelectedValue = ot.Maquina.ToString();
                    TextBoxTercero.Text = ot.Tercero;
                    TextBoxTinta.Text = ot.Tinta;
                    TextBoxTiro.Text = ot.Tiro;
                    TextBoxRetiro.Text = ot.Retiro;
                    RadioButtonListBarnizO.SelectedValue = ot.BarnizOpaco.ToString();
                    RadioButtonListBarnizB.SelectedValue = ot.BarnizBrillante.ToString();
                    RadioButtonListTerminacion1.SelectedValue = ot.Terminacion1.ToString();
                    CheckBoxListTerminacion2.SelectedValue = ot.Terminacion2.ToString();
                    TextBoxFolio.Text = ot.Folio.ToString();
                    TextBoxObs.Text = ot.Observacion;
                    RadioButtonListEstado.SelectedValue = ot.Estado.ToString();

                    Conexion c = new Conexion();
                    SqlConnection con = new SqlConnection(c.conectar());
                    SqlCommand cmd = new SqlCommand("select Maquina_id, Machine_name from Maquina", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    DropDownListMaquina.DataSource = ds;
                    DropDownListMaquina.DataTextField = "Machine_name";
                    DropDownListMaquina.DataValueField = "Maquina_id";
                    DropDownListMaquina.DataBind();
                    con.Close();
            }
        }

        protected void ButtonModificar_Click(object sender, EventArgs e)
        {
            int id;
            int empID;
            int adID;
            string fechaIngreso;
            string fechaEntrega;
            string cliente;
            string trabajo;
            int reimpresionOT;
            int cantidad;
            int cotizacion;
            string papel;
            int cantPliegos;
            string formato;
            string tamanoArticulo;
            string fechaTermino;
            string factN;
            string guiaN;
            int pruebaColor;
            int maqueta;
            string montaje;
            string nota;
            string tamanoPapel;
            string tamanoTerminado;
            string tiraje;
            string sobrante;
            string original;
            string copia;
            int maquina;
            string tercero;
            string tinta;
            string tiro;
            string retiro;
            int barnizOpaco;
            int barnizBrillante;
            int terminacion1;
            int terminacion2;
            int folio;
            string observacion;
            int estado;

            id = int.Parse(TextBoxID.Text);
            if (ad == null)
            {
                adID = int.Parse(TextBoxAD.Text);
                empID = emp.Emp_id;
            }
            else
            {
                empID = int.Parse(TextBoxEMP.Text);
                adID = ad.Ad_id;
            }

            fechaIngreso = TextBoxFechaIngreso.Text;
            fechaEntrega = TextBoxFechaEntrega.Text;
            cliente = TextBoxCliente.Text;
            trabajo = TextBoxTrabajo.Text;
            reimpresionOT = int.Parse(TextBoxReimpresion.Text);
            cantidad = int.Parse(TextBoxCantidad.Text);
            cotizacion = int.Parse(TextBoxCotizacion.Text);
            papel = TextBoxPapel.Text;
            cantPliegos = int.Parse(TextBoxCantPliegos.Text);
            formato = TextBoxFormato.Text;
            tamanoArticulo = TextBoxTamanoArticulo.Text;
            fechaTermino = TextBoxTerminado.Text;
            factN = TextBoxFactN.Text;
            guiaN = TextBoxGuiaN.Text;
            pruebaColor = int.Parse(RadioButtonListPruebaColor.SelectedValue);
            maqueta = int.Parse(RadioButtonListMaqueta.SelectedValue);
            if (TextBoxMontaje.Text.Equals(""))
            {
                montaje = FileUploadMontaje.FileName;
            }
            else
            {
                montaje = TextBoxMontaje.Text;
            }
            nota = TextBoxNota.Text;
            tamanoPapel = TextBoxTamanoPapel.Text;
            tamanoTerminado = TextBoxTamanoTerminado.Text;
            tiraje = TextBoxTiraje.Text;
            sobrante = TextBoxSobrante.Text;
            original = TextBoxOriginal.Text;
            copia = TextBoxCopia.Text;
            maquina = int.Parse(DropDownListMaquina.SelectedValue);
            tercero = TextBoxTercero.Text;
            tinta = TextBoxTinta.Text;
            tiro = TextBoxTiro.Text;
            retiro = TextBoxRetiro.Text;
            barnizOpaco = int.Parse(RadioButtonListBarnizO.SelectedValue);
            barnizBrillante = int.Parse(RadioButtonListBarnizB.SelectedValue);
            terminacion1 = int.Parse(RadioButtonListTerminacion1.SelectedValue);
            terminacion2 = int.Parse(CheckBoxListTerminacion2.SelectedValue);
            folio = int.Parse(TextBoxFolio.Text);
            observacion = TextBoxObs.Text;
            estado = int.Parse(RadioButtonListEstado.SelectedValue);

            if (TextBoxMontaje.Text.Equals(""))
            {
                string pathToCheck = HttpContext.Current.Server.MapPath("\\img\\" + montaje);
                string tempfileName = "";
                if (System.IO.File.Exists(pathToCheck))
                {
                    int counter = 1;
                    while (System.IO.File.Exists(pathToCheck))
                    {

                        tempfileName = "(" + counter.ToString() + ") " + montaje;
                        pathToCheck = HttpContext.Current.Server.MapPath("\\img\\" + tempfileName);
                        counter++;
                    }
                    montaje = tempfileName;
                }
                FileUploadMontaje.SaveAs(HttpContext.Current.Server.MapPath("\\img\\" + montaje));
            }

            ordenTrabajo ot = new ordenTrabajo(id, empID, adID, fechaIngreso, fechaEntrega, cliente, trabajo,
                        reimpresionOT, cantidad, cotizacion, papel, cantPliegos, formato, tamanoArticulo,
                        fechaTermino, factN, guiaN, pruebaColor, maqueta, montaje, nota, tamanoPapel,
                        tamanoTerminado, tiraje, sobrante, original, copia, maquina, tercero,
                        tinta, tiro, retiro, barnizOpaco, barnizBrillante, terminacion1, terminacion2,
                        folio, observacion, estado);

            if (ordenTrabajoDAO.modificar(ot) == true)
            {
                LabelMensaje.Text = "OT Modificado";
            }
            else
            {
                LabelMensaje.Text = "Error, OT no Modificado";
            }
        }
    }
}