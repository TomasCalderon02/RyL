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
    public class ordenTrabajoDAO
    {
        private static List<ordenTrabajo> alOT = new List<ordenTrabajo>();

        public static Boolean agregar(ordenTrabajo ot)
        {
            bool estado = true;
            try
            {
                Conexion c = new Conexion();
                SqlConnection con = new SqlConnection(c.conectar());
                SqlCommand sSel = new SqlCommand("insert into OT values(@id, @empid, @adid, @reimpresionot, @cantidad, @cotizacion" +
                                                 ", @cantpliegos, @pruebacolor, @maqueta, @barnizopaco, @barnizbrillante, @terminacion1" +
                                                 ", @terminacion2, @folio, @montaje, @nota, @papel, @formato, @tamanoarticulo, @tamanopapel" +
                                                 ", @tamanoterminado, @tiraje, @sobrante, @original, @copia, @fechatermino, @factn" +
                                                 ", @guian, @fechaingreso, @fechaentrega, @cliente, @trabajo, @maquina, @tercero" +
                                                 ", @tinta, @tiro, @retiro, @estado, @observacion)", con);

                sSel.Parameters.AddWithValue("@id", ot.Id); 
                sSel.Parameters.AddWithValue("@empid", ot.EmpID);
                sSel.Parameters.AddWithValue("@adid", ot.AdID); 
                sSel.Parameters.AddWithValue("@reimpresionot", ot.ReimpresionOT); 
                sSel.Parameters.AddWithValue("@cantidad", ot.Cantidad); 
                sSel.Parameters.AddWithValue("@cotizacion", ot.Cotizacion); 
                sSel.Parameters.AddWithValue("@cantpliegos", ot.CantPliegos); 
                sSel.Parameters.AddWithValue("@pruebacolor", ot.PruebaColor); 
                sSel.Parameters.AddWithValue("@maqueta", ot.Maqueta); 
                sSel.Parameters.AddWithValue("@barnizopaco", ot.BarnizOpaco); 
                sSel.Parameters.AddWithValue("@barnizbrillante", ot.BarnizBrillante); 
                sSel.Parameters.AddWithValue("@terminacion1", ot.Terminacion1); 
                sSel.Parameters.AddWithValue("@terminacion2", ot.Terminacion2); 
                sSel.Parameters.AddWithValue("@folio", ot.Folio); 
                sSel.Parameters.AddWithValue("@montaje", ot.Montaje); 
                sSel.Parameters.AddWithValue("@nota", ot.Nota); 
                sSel.Parameters.AddWithValue("@papel", ot.Papel); 
                sSel.Parameters.AddWithValue("@formato", ot.Formato); 
                sSel.Parameters.AddWithValue("@tamanoarticulo", ot.TamanoArticulo); 
                sSel.Parameters.AddWithValue("@tamanopapel", ot.TamanoPapel); 
                sSel.Parameters.AddWithValue("@tamanoterminado", ot.TamanoTerminado); 
                sSel.Parameters.AddWithValue("@tiraje", ot.Tiraje); 
                sSel.Parameters.AddWithValue("@sobrante", ot.Sobrante); 
                sSel.Parameters.AddWithValue("@original", ot.Original); 
                sSel.Parameters.AddWithValue("@copia", ot.Copia); 
                sSel.Parameters.AddWithValue("@fechatermino", ot.FechaTermino); 
                sSel.Parameters.AddWithValue("@factn", ot.FactN); 
                sSel.Parameters.AddWithValue("@guian", ot.GuiaN); 
                sSel.Parameters.AddWithValue("@fechaingreso", ot.FechaIngreso); 
                sSel.Parameters.AddWithValue("@fechaentrega", ot.FechaEntrega); 
                sSel.Parameters.AddWithValue("@cliente", ot.Cliente); 
                sSel.Parameters.AddWithValue("@trabajo", ot.Trabajo); 
                sSel.Parameters.AddWithValue("@maquina", ot.Maquina); 
                sSel.Parameters.AddWithValue("@tercero", ot.Tercero); 
                sSel.Parameters.AddWithValue("@tinta", ot.Tinta); 
                sSel.Parameters.AddWithValue("@tiro", ot.Tiro); 
                sSel.Parameters.AddWithValue("@retiro", ot.Retiro); 
                sSel.Parameters.AddWithValue("@estado", ot.Estado); 
                sSel.Parameters.AddWithValue("@observacion", ot.Observacion);

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

        public static Boolean modificar(ordenTrabajo ot)
        {
            bool estado = true;
            try
            {
                Conexion c = new Conexion();
                SqlConnection con = new SqlConnection(c.conectar());
                SqlCommand sSel = new SqlCommand("update OT set Emp_id= @empid" +
                                        " ,AD_id=@adid" +
                                        " ,ReimpresionOT=@reimpresionot" +
                                        " ,Cantidad=@cantidad"+
                                        " ,Cotizacion=@cotizacion" +
                                        " ,Cant_pliego=@cantpliegos" +
                                        " ,Prueba_Color=@pruebacolor" +
                                        " ,Maqueta=@maqueta" +
                                        " ,Barniz_opaco=@barnizopaco" +
                                        " ,Barniz_brillante=@barnizbrillante" +
                                        " ,Terminacion1=@terminacion1" +
                                        " ,Terminacion2=@terminacion2" +
                                        " ,Folio=@folio" +
                                        " ,Montaje=@montaje" +
                                        " ,Nota=@nota" +
                                        " ,Papel=@papel" +
                                        " ,Formato=@formato" +
                                        " ,Tamaño_A=@tamanoarticulo" +
                                        " ,Tamaño_P=@tamanopapel" +
                                        " ,Tamaño_T=@tamanoterminado" +
                                        " ,Tiraje=@sobrante" +
                                        " ,Sobrante=@sobrante" +
                                        " ,Original=@original" +
                                        " ,Copia=@copia" +
                                        " ,Fecha=@fechatermino" +
                                        " ,FactN=@factn" +
                                        " ,GuiaN=@guian" +
                                        " ,FechaI=@fechaingreso" +
                                        " ,FechaE=@fechaentrega" +
                                        " ,Rut_cliente=@cliente" +
                                        " ,Trabajo=@trabajo" +
                                        " ,Maquina_id=@maquina" +
                                        " ,Tercero=@tercero" +
                                        " ,Tinta=@tinta" +
                                        " ,Tiro=@tiro" +
                                        " ,Retiro=@retiro" +
                                        " ,Estado=@estado" +
                                        " ,Observacion=@observacion" +
                                        " where OT_id= @id", con);

                sSel.Parameters.AddWithValue("@id", ot.Id);
                sSel.Parameters.AddWithValue("@empid", ot.EmpID);
                sSel.Parameters.AddWithValue("@adid", ot.AdID);
                sSel.Parameters.AddWithValue("@reimpresionot", ot.ReimpresionOT);
                sSel.Parameters.AddWithValue("@cantidad", ot.Cantidad);
                sSel.Parameters.AddWithValue("@cotizacion", ot.Cotizacion);
                sSel.Parameters.AddWithValue("@cantpliegos", ot.CantPliegos);
                sSel.Parameters.AddWithValue("@pruebacolor", ot.PruebaColor);
                sSel.Parameters.AddWithValue("@maqueta", ot.Maqueta);
                sSel.Parameters.AddWithValue("@barnizopaco", ot.BarnizOpaco);
                sSel.Parameters.AddWithValue("@barnizbrillante", ot.BarnizBrillante);
                sSel.Parameters.AddWithValue("@terminacion1", ot.Terminacion1);
                sSel.Parameters.AddWithValue("@terminacion2", ot.Terminacion2);
                sSel.Parameters.AddWithValue("@folio", ot.Folio);
                sSel.Parameters.AddWithValue("@montaje", ot.Montaje);
                sSel.Parameters.AddWithValue("@nota", ot.Nota);
                sSel.Parameters.AddWithValue("@papel", ot.Papel);
                sSel.Parameters.AddWithValue("@formato", ot.Formato);
                sSel.Parameters.AddWithValue("@tamanoarticulo", ot.TamanoArticulo);
                sSel.Parameters.AddWithValue("@tamanopapel", ot.TamanoPapel);
                sSel.Parameters.AddWithValue("@tamanoterminado", ot.TamanoTerminado);
                sSel.Parameters.AddWithValue("@tiraje", ot.Tiraje);
                sSel.Parameters.AddWithValue("@sobrante", ot.Sobrante);
                sSel.Parameters.AddWithValue("@original", ot.Original);
                sSel.Parameters.AddWithValue("@copia", ot.Copia);
                sSel.Parameters.AddWithValue("@fechatermino", ot.FechaTermino);
                sSel.Parameters.AddWithValue("@factn", ot.FactN);
                sSel.Parameters.AddWithValue("@guian", ot.GuiaN);
                sSel.Parameters.AddWithValue("@fechaingreso", ot.FechaIngreso);
                sSel.Parameters.AddWithValue("@fechaentrega", ot.FechaEntrega);
                sSel.Parameters.AddWithValue("@cliente", ot.Cliente);
                sSel.Parameters.AddWithValue("@trabajo", ot.Trabajo);
                sSel.Parameters.AddWithValue("@maquina", ot.Maquina);
                sSel.Parameters.AddWithValue("@tercero", ot.Tercero);
                sSel.Parameters.AddWithValue("@tinta", ot.Tinta);
                sSel.Parameters.AddWithValue("@tiro", ot.Tiro);
                sSel.Parameters.AddWithValue("@retiro", ot.Retiro);
                sSel.Parameters.AddWithValue("@estado", ot.Estado);
                sSel.Parameters.AddWithValue("@observacion", ot.Observacion);

                SqlDataAdapter da;
                DataTable dt = new DataTable();
                da = new SqlDataAdapter(sSel);
                da.Fill(dt);
            }
            catch (Exception ev)
            {
                Debug.WriteLine("Error: " + ev.Message);
                estado = false;
            }
            return estado;
        }

        public static ordenTrabajo buscar(int id)
        {
            ordenTrabajo ot = null;
            try
            {
                Conexion c = new Conexion();
                SqlConnection con = new SqlConnection(c.conectar());
                SqlCommand sSel = new SqlCommand("SELECT * FROM OT WHERE OT_id = @id", con);

                sSel.Parameters.AddWithValue("@id", id);

                SqlDataAdapter da;
                DataTable dt = new DataTable();

                da = new SqlDataAdapter(sSel);
                da.Fill(dt);

                int mId = int.Parse(dt.Rows[0][0].ToString());
                int empID = int.Parse(dt.Rows[0][1].ToString());
                int adID = int.Parse(dt.Rows[0][2].ToString());
                int reimpresionOT = int.Parse(dt.Rows[0][3].ToString());
                int cantidad = int.Parse(dt.Rows[0][4].ToString());
                int cotizacion = int.Parse(dt.Rows[0][5].ToString());
                int cantPliegos = int.Parse(dt.Rows[0][6].ToString());
                int pruebaColor = int.Parse(dt.Rows[0][7].ToString());
                int maqueta = int.Parse(dt.Rows[0][8].ToString());
                int barnizOpaco = int.Parse(dt.Rows[0][9].ToString());
                int barnizBrillante = int.Parse(dt.Rows[0][10].ToString());
                int terminacion1 = int.Parse(dt.Rows[0][11].ToString());
                int terminacion2 = int.Parse(dt.Rows[0][12].ToString());
                int folio = int.Parse(dt.Rows[0][13].ToString());
                string montaje = dt.Rows[0][14].ToString();
                string nota = dt.Rows[0][15].ToString();
                string papel = dt.Rows[0][16].ToString();
                string formato = dt.Rows[0][17].ToString();
                string tamanoArticulo = dt.Rows[0][18].ToString();
                string tamanoPapel = dt.Rows[0][19].ToString();
                string tamanoTerminado = dt.Rows[0][20].ToString();
                string tiraje = dt.Rows[0][21].ToString();
                string sobrante = dt.Rows[0][22].ToString();
                string original = dt.Rows[0][23].ToString();
                string copia = dt.Rows[0][24].ToString();
                string fechaTermino = dt.Rows[0][25].ToString();
                string factN = dt.Rows[0][26].ToString();
                string guiaN = dt.Rows[0][27].ToString();
                string fechaIngreso = dt.Rows[0][28].ToString();
                string fechaEntrega = dt.Rows[0][29].ToString();
                string cliente = dt.Rows[0][30].ToString();
                string trabajo = dt.Rows[0][31].ToString();
                int maquina = int.Parse(dt.Rows[0][32].ToString());
                string tercero = dt.Rows[0][33].ToString();
                string tinta = dt.Rows[0][34].ToString();
                string tiro = dt.Rows[0][35].ToString();
                string retiro = dt.Rows[0][36].ToString();
                int estado = int.Parse(dt.Rows[0][37].ToString());
                string observacion = dt.Rows[0][38].ToString();

                ot = new ordenTrabajo(mId, empID, adID, fechaIngreso, fechaEntrega, cliente, trabajo,
            reimpresionOT, cantidad, cotizacion, papel, cantPliegos, formato, tamanoArticulo,
            fechaTermino, factN, guiaN, pruebaColor, maqueta, montaje, nota, tamanoPapel,
            tamanoTerminado, tiraje, sobrante, original, copia, maquina, tercero,
            tinta, tiro, retiro, barnizOpaco, barnizBrillante, terminacion1, terminacion2,
            folio, observacion, estado);

            }
            catch (Exception ev)
            {
                Debug.WriteLine("Error: " + ev.Message);
            }
            return ot;
        }

        public static List<ordenTrabajo> ObtenerDatos()
        {
            alOT.Clear();

            Conexion con = new Conexion();
            string sCnn = con.conectar();
            string sSel = "SELECT * FROM OT";
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
                int empID;
                int adID;
                int reimpresionOT;
                int cantidad;
                int cotizacion;
                int cantPliegos;
                int pruebaColor;
                int maqueta;
                int barnizOpaco;
                int barnizBrillante;
                int terminacion1;
                int terminacion2;
                int folio;
                string montaje;
                string nota;
                string papel;
                string formato;
                string tamanoArticulo;
                string tamanoPapel;
                string tamanoTerminado;
                string tiraje;
                string sobrante;
                string original;
                string copia;
                string fechaTermino;
                string factN;
                string guiaN;
                string fechaIngreso;
                string fechaEntrega;
                string cliente;
                string trabajo;
                int maquina;
                string tercero;
                string tinta;
                string tiro;
                string retiro;
                int estado;
                string observacion;

                int fila = 0;
                for (; fila < totalFilas; fila++)
                {
                    id = int.Parse(dt.Rows[fila][0].ToString());
                    empID = int.Parse(dt.Rows[fila][1].ToString());
                    adID = int.Parse(dt.Rows[fila][2].ToString());
                    reimpresionOT = int.Parse(dt.Rows[fila][3].ToString());
                    cantidad = int.Parse(dt.Rows[fila][4].ToString());
                    cotizacion = int.Parse(dt.Rows[fila][5].ToString());
                    cantPliegos = int.Parse(dt.Rows[fila][6].ToString());
                    pruebaColor = int.Parse(dt.Rows[fila][7].ToString());
                    maqueta = int.Parse(dt.Rows[fila][8].ToString());
                    barnizOpaco = int.Parse(dt.Rows[fila][9].ToString());
                    barnizBrillante = int.Parse(dt.Rows[fila][10].ToString());
                    terminacion1 = int.Parse(dt.Rows[fila][11].ToString());
                    terminacion2 = int.Parse(dt.Rows[fila][12].ToString());
                    folio = int.Parse(dt.Rows[fila][13].ToString());
                    montaje = dt.Rows[fila][14].ToString();
                    nota = dt.Rows[fila][15].ToString();
                    papel = dt.Rows[fila][16].ToString();
                    formato = dt.Rows[fila][17].ToString();
                    tamanoArticulo = dt.Rows[fila][18].ToString();
                    tamanoPapel = dt.Rows[fila][19].ToString();
                    tamanoTerminado = dt.Rows[fila][20].ToString();
                    tiraje = dt.Rows[fila][21].ToString();
                    sobrante = dt.Rows[fila][22].ToString();
                    original = dt.Rows[fila][23].ToString();
                    copia = dt.Rows[fila][24].ToString();
                    fechaTermino = dt.Rows[fila][25].ToString();
                    factN = dt.Rows[fila][26].ToString();
                    guiaN = dt.Rows[fila][27].ToString();
                    fechaIngreso = dt.Rows[fila][28].ToString();
                    fechaEntrega = dt.Rows[fila][29].ToString();
                    cliente = dt.Rows[fila][30].ToString();
                    trabajo = dt.Rows[fila][31].ToString();
                    maquina = int.Parse(dt.Rows[fila][32].ToString());
                    tercero = dt.Rows[fila][33].ToString();
                    tinta = dt.Rows[fila][34].ToString();
                    tiro = dt.Rows[fila][35].ToString();
                    retiro = dt.Rows[fila][36].ToString();
                    estado = int.Parse(dt.Rows[fila][37].ToString());
                    observacion = dt.Rows[fila][38].ToString();

                    ordenTrabajo ot = new ordenTrabajo(id, empID, adID, fechaIngreso, fechaEntrega, cliente, trabajo,
                        reimpresionOT, cantidad, cotizacion, papel, cantPliegos, formato, tamanoArticulo,
                        fechaTermino, factN, guiaN, pruebaColor, maqueta, montaje, nota, tamanoPapel,
                        tamanoTerminado, tiraje, sobrante, original, copia, maquina, tercero,
                        tinta, tiro, retiro, barnizOpaco, barnizBrillante, terminacion1, terminacion2,
                        folio, observacion, estado);

                    alOT.Add(ot);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }
            return alOT;
        }

        public static List<ordenTrabajo> Filtro(string campo, string valor)
        {
            alOT.Clear();

            Conexion c = new Conexion();
            SqlConnection con = new SqlConnection(c.conectar());
            SqlCommand sSel = new SqlCommand("SELECT * FROM OT where "+ campo +"= @valor", con);

            sSel.Parameters.AddWithValue("@valor", valor);

            //representa datos y conexión a bd para rellenar un dataset
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            try
            { //inicializa un objeto de sql
                da = new SqlDataAdapter(sSel);
                //Fill agrega las filas necesarias
                da.Fill(dt);
                //Label1.Text = String.Format("Total datos en la tabla: {0}", dt.Rows.Count);

                int totalFilas = dt.Rows.Count;

                int id;
                int empID;
                int adID;
                int reimpresionOT;
                int cantidad;
                int cotizacion;
                int cantPliegos;
                int pruebaColor;
                int maqueta;
                int barnizOpaco;
                int barnizBrillante;
                int terminacion1;
                int terminacion2;
                int folio;
                string montaje;
                string nota;
                string papel;
                string formato;
                string tamanoArticulo;
                string tamanoPapel;
                string tamanoTerminado;
                string tiraje;
                string sobrante;
                string original;
                string copia;
                string fechaTermino;
                string factN;
                string guiaN;
                string fechaIngreso;
                string fechaEntrega;
                string cliente;
                string trabajo;
                int maquina;
                string tercero;
                string tinta;
                string tiro;
                string retiro;
                int estado;
                string observacion;

                int fila = 0;
                for (; fila < totalFilas; fila++)
                {
                    id = int.Parse(dt.Rows[fila][0].ToString());
                    empID = int.Parse(dt.Rows[fila][1].ToString());
                    adID = int.Parse(dt.Rows[fila][2].ToString());
                    reimpresionOT = int.Parse(dt.Rows[fila][3].ToString());
                    cantidad = int.Parse(dt.Rows[fila][4].ToString());
                    cotizacion = int.Parse(dt.Rows[fila][5].ToString());
                    cantPliegos = int.Parse(dt.Rows[fila][6].ToString());
                    pruebaColor = int.Parse(dt.Rows[fila][7].ToString());
                    maqueta = int.Parse(dt.Rows[fila][8].ToString());
                    barnizOpaco = int.Parse(dt.Rows[fila][9].ToString());
                    barnizBrillante = int.Parse(dt.Rows[fila][10].ToString());
                    terminacion1 = int.Parse(dt.Rows[fila][11].ToString());
                    terminacion2 = int.Parse(dt.Rows[fila][12].ToString());
                    folio = int.Parse(dt.Rows[fila][13].ToString());
                    montaje = dt.Rows[fila][14].ToString();
                    nota = dt.Rows[fila][15].ToString();
                    papel = dt.Rows[fila][16].ToString();
                    formato = dt.Rows[fila][17].ToString();
                    tamanoArticulo = dt.Rows[fila][18].ToString();
                    tamanoPapel = dt.Rows[fila][19].ToString();
                    tamanoTerminado = dt.Rows[fila][20].ToString();
                    tiraje = dt.Rows[fila][21].ToString();
                    sobrante = dt.Rows[fila][22].ToString();
                    original = dt.Rows[fila][23].ToString();
                    copia = dt.Rows[fila][24].ToString();
                    fechaTermino = dt.Rows[fila][25].ToString();
                    factN = dt.Rows[fila][26].ToString();
                    guiaN = dt.Rows[fila][27].ToString();
                    fechaIngreso = dt.Rows[fila][28].ToString();
                    fechaEntrega = dt.Rows[fila][29].ToString();
                    cliente = dt.Rows[fila][30].ToString();
                    trabajo = dt.Rows[fila][31].ToString();
                    maquina = int.Parse(dt.Rows[fila][32].ToString());
                    tercero = dt.Rows[fila][33].ToString();
                    tinta = dt.Rows[fila][34].ToString();
                    tiro = dt.Rows[fila][35].ToString();
                    retiro = dt.Rows[fila][36].ToString();
                    estado = int.Parse(dt.Rows[fila][37].ToString());
                    observacion = dt.Rows[fila][38].ToString();

                    ordenTrabajo ot = new ordenTrabajo(id, empID, adID, fechaIngreso, fechaEntrega, cliente, trabajo,
            reimpresionOT, cantidad, cotizacion, papel, cantPliegos, formato, tamanoArticulo,
            fechaTermino, factN, guiaN, pruebaColor, maqueta, montaje, nota, tamanoPapel,
            tamanoTerminado, tiraje, sobrante, original, copia, maquina, tercero,
            tinta, tiro, retiro, barnizOpaco, barnizBrillante, terminacion1, terminacion2,
            folio, observacion, estado);
                    alOT.Add(ot);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }
            return alOT;
        }
    }
}
