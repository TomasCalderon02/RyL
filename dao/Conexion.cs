using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dao
{
    public class Conexion
    {
        public string conectar()
        {
            return "Server=tcp:rylimpresos.database.windows.net,1433;Initial Catalog=Imprenta;Persist Security Info=False;User ID=ryladmin;Password=Ryl*impresos;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            //Server=tcp:rylimpresos.database.windows.net,1433;Database=Impresos;Initial Catalog=Impresos;Persist Security Info=False;User ID=ryladmin;Password=Ryl*impresos;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
            //Server=localhost\\SQLEXPRESS;Database=Imprenta;Trusted_Connection=True;
        }
    }
}
