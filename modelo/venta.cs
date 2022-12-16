using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class venta
    {
        private int id;
        private int adID;

        private int doc;
        private string rutCliente;
        private string razonSocial;
        private int folio;
        private string fechaDocto;
        private int montoTotal;
        private string fechaPago;
        private string vendedor;

        public venta(int id, int adID, int doc, string rutCliente, string razonSocial,
            int folio, string fechaDocto, int montoTotal, string fechaPago, string vendedor)
        {
            this.id = id;
            this.adID = adID;
            this.doc = doc;
            this.rutCliente = rutCliente;
            this.razonSocial = razonSocial;
            this.folio = folio;
            this.fechaDocto = fechaDocto;
            this.montoTotal = montoTotal;
            this.fechaPago = fechaPago;
            this.vendedor = vendedor;
        }

        public int Id { get => id; set => id = value; }
        public int AdID { get => adID; set => adID = value; }
        public int Doc { get => doc; set => doc = value; }
        public string RutCliente { get => rutCliente; set => rutCliente = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public int Folio { get => folio; set => folio = value; }
        public string FechaDocto { get => fechaDocto; set => fechaDocto = value; }
        public int MontoTotal { get => montoTotal; set => montoTotal = value; }
        public string FechaPago { get => fechaPago; set => fechaPago = value; }
        public string Vendedor { get => vendedor; set => vendedor = value; }

        override
        public string ToString()
        {
            return id
                + ", "
                + adID
                + ", "
                + doc
                + ", "
                + rutCliente
                + ", "
                + razonSocial
                + ", "
                + folio
                + ", "
                + fechaDocto
                + ", "
                + montoTotal
                + ", "
                + fechaPago
                + ", "
                + vendedor;
        }
    }
}
