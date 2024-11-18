using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class VendedorDTO
    {

        public int ID_Vendedor { get; set; }
        public int ID_Rol { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public int Edad { get; set; }
        public string Usuario { get; set; }
        public string Contra { get; set; }
        public int ID_Sucursal { get; set; }
        public int Estado { get; set; }

    }
}
