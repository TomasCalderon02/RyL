using modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dao
{
    public class ventaDAO
    {
        private static List<venta> alV = new List<venta>();

        public static Boolean agregar(venta v)
        {
            bool estado = true;

            try
            {
                Conexion c = new Conexion();
                SqlConnection con = new SqlConnection(c.conectar());
                SqlCommand sSel = new SqlCommand("insert into Ventas values(@id, @adid, @doc, @folio, @montotal" +
                                                ", @rutcliente, @razonsocial, @fechadocto, @fechapago, @vendedor)", con);

                sSel.Parameters.AddWithValue("@id", v.Id);
                sSel.Parameters.AddWithValue("@adid", v.AdID);
                sSel.Parameters.AddWithValue("@doc", v.Doc);
                sSel.Parameters.AddWithValue("@folio", v.Folio);
                sSel.Parameters.AddWithValue("@montotal", v.MontoTotal);
                sSel.Parameters.AddWithValue("@rutcliente", v.RutCliente);
                sSel.Parameters.AddWithValue("@razonsocial", v.RazonSocial);
                sSel.Parameters.AddWithValue("@fechadocto", v.FechaDocto);
                sSel.Parameters.AddWithValue("@fechapago", v.FechaPago);
                sSel.Parameters.AddWithValue("@vendedor", v.Vendedor);

                SqlDataAdapter da;
                DataTable dt = new DataTable();
                da = new SqlDataAdapter(sSel);
                da.Fill(dt);

                Debug.WriteLine("********************   *******************cantidad de lineas" + dt.Rows.Count);
            }
            catch (Exception ev)
            {
                Debug.WriteLine("Error: " + ev.Message);
                estado = false;
            }

            return estado;
        }

        public static Boolean modificar(venta v)
        {
            bool estado = true;

            try
            {
                Conexion c = new Conexion();
                SqlConnection con = new SqlConnection(c.conectar());
                SqlCommand sSel = new SqlCommand("update Ventas set AD_id= @adid" +
                                                 ", Doc=@doc" +
                                                 ", folio=@folio" +
                                                 ", Monto_T=@montotal" +
                                                 ", Rut_Cliente=@rutcliente" +
                                                 ", Razon_social=@razonsocial" +
                                                 ", Fecha_doc=@fechadocto" +
                                                 ", Fecha_pago=@fechapago" +
                                                 ", Vendedor=@vendedor" +
                                                 " where Venta_id= @id", con);

                sSel.Parameters.AddWithValue("@id", v.Id);
                sSel.Parameters.AddWithValue("@adid", v.AdID);
                sSel.Parameters.AddWithValue("@doc", v.Doc);
                sSel.Parameters.AddWithValue("@folio", v.Folio);
                sSel.Parameters.AddWithValue("@montotal", v.MontoTotal);
                sSel.Parameters.AddWithValue("@rutcliente", v.RutCliente);
                sSel.Parameters.AddWithValue("@razonsocial", v.RazonSocial);
                sSel.Parameters.AddWithValue("@fechadocto", v.FechaDocto);
                sSel.Parameters.AddWithValue("@fechapago", v.FechaPago);
                sSel.Parameters.AddWithValue("@vendedor", v.Vendedor);

                SqlDataAdapter da;
                DataTable dt = new DataTable();
                da = new SqlDataAdapter(sSel);
                da.Fill(dt);

                Debug.WriteLine("********************   *******************cantidad de lineas" + dt.Rows.Count);
            }
            catch (Exception ev)
            {
                Debug.WriteLine("Error: " + ev.Message);
                estado = false;
            }

            return estado;
        }

        public static venta buscar(int id)
        {
            venta v = null;
            try
            {
                Conexion c = new Conexion();
                SqlConnection con = new SqlConnection(c.conectar());
                SqlCommand sSel = new SqlCommand("SELECT * FROM Ventas WHERE Venta_id = @id", con);

                sSel.Parameters.AddWithValue("@id", id);

                SqlDataAdapter da;
                DataTable dt = new DataTable();

                da = new SqlDataAdapter(sSel);
                da.Fill(dt);

                //de la fila , columna de la tabla obtenida

                int mId = int.Parse(dt.Rows[0][0].ToString());
                int adID = int.Parse(dt.Rows[0][1].ToString());
                int doc = int.Parse(dt.Rows[0][2].ToString());
                int folio = int.Parse(dt.Rows[0][3].ToString());
                int montoTotal = int.Parse(dt.Rows[0][4].ToString());
                string rutCliente = dt.Rows[0][5].ToString();
                string razonSocial = dt.Rows[0][6].ToString();
                string fechaDocto = dt.Rows[0][7].ToString();
                string fechaPago = dt.Rows[0][8].ToString();
                string vendedor = dt.Rows[0][9].ToString();

                v = new venta(mId, adID, doc, rutCliente, razonSocial, folio, fechaDocto, montoTotal, fechaPago, vendedor);
            }
            catch (Exception ev)
            {
                Debug.WriteLine("Error: " + ev.Message);
            }
            return v;
        }

        public static List<venta> ObtenerDatos()
        {
            alV.Clear();
            Conexion con = new Conexion();
            string sCnn = con.conectar();
            string sSel = "SELECT * FROM Ventas";
            //representa datos y conexión a bd para rellenar un dataset
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            try
            { //inicializa un objeto de sql
                da = new SqlDataAdapter(sSel, sCnn);
                //Fill agrega las filas necesarias
                da.Fill(dt);
                //Label1.Text = String.Format("Total datos en la tabla: {0}", dt.Rows.Count);

                int totalFilas = dt.Rows.Count;

                int id;
                int adID;
                int doc;
                string rutCliente;
                string razonSocial;
                int folio;
                string fechaDocto;
                int montoTotal;
                string fechaPago;
                string vendedor;

                int fila = 0;
                for (; fila < totalFilas; fila++)
                {

                    id = int.Parse(dt.Rows[fila][0].ToString());
                    adID = int.Parse(dt.Rows[fila][1].ToString());
                    doc = int.Parse(dt.Rows[fila][2].ToString());
                    folio = int.Parse(dt.Rows[fila][3].ToString());
                    montoTotal = int.Parse(dt.Rows[fila][4].ToString());
                    rutCliente = dt.Rows[fila][5].ToString();
                    razonSocial = dt.Rows[fila][6].ToString();
                    fechaDocto = dt.Rows[fila][7].ToString();
                    fechaPago = dt.Rows[fila][8].ToString();
                    vendedor = dt.Rows[fila][9].ToString();

                    venta v = new venta(id, adID, doc, rutCliente, razonSocial, folio, fechaDocto, montoTotal, fechaPago, vendedor);
                    alV.Add(v);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }

            return alV;
        }
    }
}
