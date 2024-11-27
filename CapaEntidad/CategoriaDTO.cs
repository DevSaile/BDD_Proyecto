using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CategoriaDTO
    {
        public int? ID_Categoria { get; set; }
        public string Nombre { get; set; }
        public string NombreEstado { get; set; }

        public int? Estado { get; set; }
    }
}
