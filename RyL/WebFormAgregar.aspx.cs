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
    public partial class WebFormAgregar : System.Web.UI.Page
    {
        int n = 1;
        private admin ad;
        private empleado emp;
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

            foreach (ordenTrabajo ot in ordenTrabajoDAO.ObtenerDatos())
            {
                n++;
            }
            TextBoxID.Text = n.ToString();

            if (IsPostBack == false)
            {
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

                //temporal
                //TextBoxFechaIngreso.Text = "2022-12-20";
                //TextBoxFechaEntrega.Text = "2023-01-10";
                //TextBoxCliente.Text = "9525882-4";
                //TextBoxTrabajo.Text = "Planificador";
                //TextBoxReimpresion.Text = "1";
                //TextBoxCantidad.Text = "250";
                //TextBoxCotizacion.Text = "1";
                //TextBoxPapel.Text = "Tapa Couche 170gr";
                //TextBoxCantPliegos.Text = "1000";
                //TextBoxFormato.Text = "80x90";
                //TextBoxTamanoArticulo.Text = "20x40";
                //TextBoxTerminado.Text = "2023-01-05";
                //TextBoxFactN.Text = "1";
                //TextBoxGuiaN.Text = "1";
                //RadioButtonListPruebaColor.SelectedValue = "0";
                //RadioButtonListMaqueta.SelectedValue = "0";
                //TextBoxNota.Text = "nota sobre el trabajo";
                //TextBoxTamanoPapel.Text = "70x40";
                //TextBoxTamanoTerminado.Text = "20x40";
                //TextBoxTiraje.Text = "250/300";
                //TextBoxSobrante.Text = "100/200";
                //TextBoxOriginal.Text = "Aplicable";
                //TextBoxCopia.Text = "2 copias";
                //TextBoxTercero.Text = "No Aplicable";
                //TextBoxTinta.Text = "4/4";
                //TextBoxTiro.Text = "Si";
                //TextBoxRetiro.Text = "No";
                //RadioButtonListBarnizO.SelectedValue = "0";
                //RadioButtonListBarnizB.SelectedValue = "0";
                //RadioButtonListTerminacion1.SelectedValue = "0";
                //CheckBoxListTerminacion2.SelectedValue = "0";
                //TextBoxFolio.Text = "7710";
                //TextBoxObs.Text = "observacion sobre el trabajo";
            }


        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            int id;
            int empID=0;
            int adID=0;
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
                empID = emp.Emp_id;
            }
            else
            {
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
            montaje = FileUploadMontaje.FileName;
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

            ordenTrabajo ot = new ordenTrabajo(id, empID, adID, fechaIngreso, fechaEntrega, cliente, trabajo,
                        reimpresionOT, cantidad, cotizacion, papel, cantPliegos, formato, tamanoArticulo,
                        fechaTermino, factN, guiaN, pruebaColor, maqueta, montaje, nota, tamanoPapel,
                        tamanoTerminado, tiraje, sobrante, original, copia, maquina, tercero,
                        tinta, tiro, retiro, barnizOpaco, barnizBrillante, terminacion1, terminacion2,
                        folio, observacion, estado);

            if (ordenTrabajoDAO.agregar(ot) == true)
            {
                LabelMensaje.Text = "OT Agregado";
                FileUploadMontaje.SaveAs(HttpContext.Current.Server.MapPath("\\img\\" + montaje));
                limpiar();
            }
            else
            {
                LabelMensaje.Text = "Error, OT no agregado";
            }
        }

        public void limpiar()
        {
            //TextBoxID.Text = n++.ToString();
            TextBoxFechaIngreso.Text = "";
            TextBoxFechaEntrega.Text = "";
            TextBoxCliente.Text = "";
            TextBoxTrabajo.Text = "";
            TextBoxReimpresion.Text = "";
            TextBoxCantidad.Text = "";
            TextBoxCotizacion.Text = "";
            TextBoxPapel.Text = "";
            TextBoxCantPliegos.Text = "";
            TextBoxFormato.Text = "";
            TextBoxTamanoArticulo.Text = "";
            TextBoxTerminado.Text = "";
            TextBoxFactN.Text = "";
            TextBoxGuiaN.Text = "";
            RadioButtonListPruebaColor.ClearSelection();
            RadioButtonListMaqueta.ClearSelection();
            TextBoxNota.Text = "";
            TextBoxTamanoPapel.Text = "";
            TextBoxTamanoTerminado.Text = "";
            TextBoxTiraje.Text = "";
            TextBoxSobrante.Text = "";
            TextBoxOriginal.Text = "";
            TextBoxCopia.Text = "";
            //DropDownListMaquina.SelectedValue = "1";
            TextBoxTercero.Text = "";
            TextBoxTinta.Text = "";
            TextBoxTiro.Text = "";
            TextBoxRetiro.Text = "";
            RadioButtonListBarnizO.ClearSelection();
            RadioButtonListBarnizB.ClearSelection();
            RadioButtonListTerminacion1.ClearSelection();
            CheckBoxListTerminacion2.ClearSelection();
            TextBoxFolio.Text = "";
            TextBoxObs.Text = "";
            RadioButtonListEstado.ClearSelection();
        }
    }
}