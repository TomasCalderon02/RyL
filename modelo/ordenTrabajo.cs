using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class ordenTrabajo
    {
        private int id;
        private int empID;
        private int adID;

        private string fechaIngreso;
        private string fechaEntrega;
        private string cliente;
        private string trabajo;
        private int reimpresionOT;
        private int cantidad;
        private int cotizacion;
        private string papel;
        private int cantPliegos;
        private string formato;
        private string tamanoArticulo;
        private string fechaTermino;
        private string factN; //en vola los cambio
        private string guiaN; //este igual

        private int pruebaColor;
        private int maqueta;
        private string montaje; //puede ser una foto
        private string nota;

        private string tamanoPapel;
        private string tamanoTerminado;
        private string tiraje;
        private string sobrante;
        private string original;
        private string copia; //hay 6 en el papel tiene que haber una forma mas sofisticada de hacerlo

        private int maquina;
        private string tercero; //a preguntar pa q es esto
        private string tinta;
        private string tiro;
        private string retiro;
        private int barnizOpaco;
        private int barnizBrillante;

        private int terminacion1;
        private int terminacion2; //preguntar por esto igual
        private int folio;

        private string observacion;
        private int estado; //0=pendiente 1= terminado

        public ordenTrabajo(int id, int empID, int adID, string fechaIngreso, string fechaEntrega, string cliente, string trabajo,
            int reimpresionOT, int cantidad, int cotizacion, string papel, int cantPliegos, string formato, string tamanoArticulo,
            string fechaTermino, string factN, string guiaN, int pruebaColor, int maqueta, string montaje, string nota, string tamanoPapel,
            string tamanoTerminado, string tiraje, string sobrante, string original, string copia, int maquina, string tercero,
            string tinta, string tiro, string retiro, int barnizOpaco, int barnizBrillante, int terminacion1, int terminacion2,
            int folio, string observacion, int estado)
        {
            this.id = id;
            this.empID = empID;
            this.adID = adID;
            this.fechaIngreso = fechaIngreso;
            this.fechaEntrega = fechaEntrega;
            this.cliente = cliente;
            this.trabajo = trabajo;
            this.reimpresionOT = reimpresionOT;
            this.cantidad = cantidad;
            this.cotizacion = cotizacion;
            this.papel = papel;
            this.cantPliegos = cantPliegos;
            this.formato = formato;
            this.tamanoArticulo = tamanoArticulo;
            this.fechaTermino = fechaTermino;
            this.factN = factN;
            this.guiaN = guiaN;
            this.pruebaColor = pruebaColor;
            this.maqueta = maqueta;
            this.montaje = montaje;
            this.nota = nota;
            this.tamanoPapel = tamanoPapel;
            this.tamanoTerminado = tamanoTerminado;
            this.tiraje = tiraje;
            this.sobrante = sobrante;
            this.original = original;
            this.copia = copia;
            this.maquina = maquina;
            this.tercero = tercero;
            this.tinta = tinta;
            this.tiro = tiro;
            this.retiro = retiro;
            this.barnizOpaco = barnizOpaco;
            this.barnizBrillante = barnizBrillante;
            this.terminacion1 = terminacion1;
            this.terminacion2 = terminacion2;
            this.folio = folio;
            this.observacion = observacion;
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public int EmpID { get => empID; set => empID = value; }
        public int AdID { get => adID; set => adID = value; }
        public string FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Trabajo { get => trabajo; set => trabajo = value; }
        public int ReimpresionOT { get => reimpresionOT; set => reimpresionOT = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Cotizacion { get => cotizacion; set => cotizacion = value; }
        public string Papel { get => papel; set => papel = value; }
        public int CantPliegos { get => cantPliegos; set => cantPliegos = value; }
        public string Formato { get => formato; set => formato = value; }
        public string TamanoArticulo { get => tamanoArticulo; set => tamanoArticulo = value; }
        public string FechaTermino { get => fechaTermino; set => fechaTermino = value; }
        public string FactN { get => factN; set => factN = value; }
        public string GuiaN { get => guiaN; set => guiaN = value; }
        public int PruebaColor { get => pruebaColor; set => pruebaColor = value; }
        public int Maqueta { get => maqueta; set => maqueta = value; }
        public string Montaje { get => montaje; set => montaje = value; }
        public string Nota { get => nota; set => nota = value; }
        public string TamanoPapel { get => tamanoPapel; set => tamanoPapel = value; }
        public string TamanoTerminado { get => tamanoTerminado; set => tamanoTerminado = value; }
        public string Tiraje { get => tiraje; set => tiraje = value; }
        public string Sobrante { get => sobrante; set => sobrante = value; }
        public string Original { get => original; set => original = value; }
        public string Copia { get => copia; set => copia = value; }
        public int Maquina { get => maquina; set => maquina = value; }
        public string Tercero { get => tercero; set => tercero = value; }
        public string Tinta { get => tinta; set => tinta = value; }
        public string Tiro { get => tiro; set => tiro = value; }
        public string Retiro { get => retiro; set => retiro = value; }
        public int BarnizOpaco { get => barnizOpaco; set => barnizOpaco = value; }
        public int BarnizBrillante { get => barnizBrillante; set => barnizBrillante = value; }
        public int Terminacion1 { get => terminacion1; set => terminacion1 = value; }
        public int Terminacion2 { get => terminacion2; set => terminacion2 = value; }
        public int Folio { get => folio; set => folio = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }

        override
        public string ToString()
        {
            return id
                + ", "
                + EmpID
                + ", "
                + adID
                + ", "
                + fechaIngreso
                + ", "
                + fechaEntrega
                + ", "
                + cliente
                + ", "
                + trabajo
                + ", "
                + reimpresionOT
                + ", "
                + cantidad
                + ", "
                + cotizacion
                + ", "
                + papel
                + ", "
                + cantPliegos
                + ", "
                + formato
                + ", "
                + tamanoArticulo
                + ", "
                + fechaTermino
                + ", "
                + factN
                + ", "
                + guiaN
                + ", "
                + pruebaColor
                + ", "
                + maqueta
                + ", "
                + montaje
                + ", "
                + nota
                + ", "
                + tamanoPapel
                + ", "
                + tamanoTerminado
                + ", "
                + tiraje
                + ", "
                + sobrante
                + ", "
                + original
                + ", "
                + copia
                + ", "
                + maquina
                + ", "
                + tercero
                + ", "
                + tinta
                + ", "
                + tiro
                + ", "
                + retiro
                + ", "
                + barnizOpaco
                + ", "
                + barnizBrillante
                + ", "
                + terminacion1
                + ", "
                + terminacion2
                + ", "
                + folio
                + ", "
                + observacion
                + ", "
                + estado;
        }
    }
}
