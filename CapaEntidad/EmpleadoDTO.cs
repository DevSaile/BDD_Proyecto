using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EmpleadoDTO
    {

        public int? ID_Empleado { get; set; }

        public string Nombre { get; set; }

        public string Cedula { get; set; }

        public int? Edad { get; set; }

        public int? Estado { get; set; }

        public string NombreEstado { get; set; }

        /* Varibales para el rol de usuario */

        public int? ID_Rol { get; set; }

        public string NombreRol { get; set; }

        /*  FIN Varibales para el rol de usuario */


        /* Varibales para la sucursal del ususario */

        public int? ID_Sucursal { get; set; }

        public string NombreSucursal { get; set; }


        /*  FIN Varibales para la sucursal del usuario */

    }
}
