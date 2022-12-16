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
    public class cobranzaDAO
    {
        private static List<cobranza> alC = new List<cobranza>();

        public static Boolean agregar(cobranza cobro)
        {
            bool estado = true;
            try
            {
                Conexion c = new Conexion();
                SqlConnection con = new SqlConnection(c.conectar());
                SqlCommand sSel = new SqlCommand("insert into Cobranza values(@folio, @fechaingreso, @total, @comentario)", con);

                sSel.Parameters.AddWithValue("@folio", cobro.Folio);
                sSel.Parameters.AddWithValue("@fechaingreso", cobro.FechaIngreso);
                sSel.Parameters.AddWithValue("@total", cobro.Total);
                sSel.Parameters.AddWithValue("@comentario", cobro.Comentario);

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

        public static Boolean modificar(cobranza cobro)
        {
            bool estado = true;
            try
            {
                Conexion c = new Conexion();
                SqlConnection con = new SqlConnection(c.conectar());
                SqlCommand sSel = new SqlCommand("update Cobranza set FechaIngreso= @fechaingreso " +
                                                ", Total=@total" +
                                                ",Comentario=@comentario" +
                                                " where Folio=@folio", con);

                sSel.Parameters.AddWithValue("@folio", cobro.Folio);
                sSel.Parameters.AddWithValue("@fechaingreso", cobro.FechaIngreso);
                sSel.Parameters.AddWithValue("@total", cobro.Total);
                sSel.Parameters.AddWithValue("@comentario", cobro.Comentario);

                SqlDataAdapter da;
                DataTable dt = new DataTable();
                da = new SqlDataAdapter(sSel);
                da.Fill(dt);

                //para lanzar error
                //string mrut = dt.Rows[0][0].ToString();
            }
            catch (Exception ev)
            {
                Debug.WriteLine("Error: " + ev.Message);
                estado = false;
            }
            return estado;
        }

        public static cobranza buscar(int folio)
        {
            cobranza cobro = null;
            try
            {
                Conexion c = new Conexion();
                SqlConnection con = new SqlConnection(c.conectar());
                SqlCommand sSel = new SqlCommand("SELECT * FROM Cobranza WHERE Folio= @folio", con);

                sSel.Parameters.AddWithValue("@folio", folio);

                SqlDataAdapter da;
                DataTable dt = new DataTable();

                da = new SqlDataAdapter(sSel);
                da.Fill(dt);

                folio = int.Parse(dt.Rows[0][0].ToString());
                string fechaIngreso = dt.Rows[0][1].ToString();
                int total = int.Parse(dt.Rows[0][2].ToString());
                string comentario = dt.Rows[0][3].ToString();

                cobro = new cobranza(folio, fechaIngreso, total, comentario);
            }
            catch (Exception ev)
            {
                Debug.WriteLine("Error: " + ev.Message);
            }
            return cobro;
        }

        public static List<cobranza> ObtenerDatos()
        {
            alC.Clear();

            Conexion con = new Conexion();
            string sCnn = con.conectar();
            string sSel = "SELECT * FROM Cobranza";
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

                int folio;
                string fechaIngreso;
                int total;
                string comentario;

                int fila = 0;
                for (; fila < totalFilas; fila++)
                {
                    folio = int.Parse(dt.Rows[fila][0].ToString());
                    fechaIngreso = dt.Rows[fila][1].ToString();
                    total = int.Parse(dt.Rows[fila][2].ToString());
                    comentario = dt.Rows[fila][3].ToString();

                    cobranza cobro = new cobranza(folio, fechaIngreso, total, comentario);

                    alC.Add(cobro);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }
            return alC;
        }

    }
}
