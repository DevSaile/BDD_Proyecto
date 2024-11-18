using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra_Entrada
    {

        public int ID_Entrada { get; set; }
        public int Estado { get; set; }
        public int ID_Proveedor { get; set; }
        public int ID_Producto { get; set; }
        public DateTime Fecha_Compra { get; set; }

    }
}
