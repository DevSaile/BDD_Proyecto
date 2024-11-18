using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaEntidad
{
    public class Compra_EntradaDTO
    {

        public int ID_Entrada { get; set; }

        public int? Estado { get; set; }

        public int? ID_Proveedor { get; set; }

        public string Nombre_Proveedor { get; set; } // Propiedad para el nombre del proveedor

        public int? ID_Producto { get; set; }

        public string Nombre_Producto { get; set; } // Propiedad para el nombre del producto

        public DateTime? Fecha_Compra { get; set; }

        /*public ProveedorDTO Proveedor { get; set; } 
        public ProductoDTO Producto { get; set; }*/

    }
}
