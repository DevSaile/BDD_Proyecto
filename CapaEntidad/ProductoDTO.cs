using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ProductoDTO
    {

        public int ID_Producto { get; set; }
        public int ID_Categoria { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Compra { get; set; }
        public decimal Precio_Producto { get; set; }
        public int ID_Sucursal { get; set; }
        public string DetalleS { get; set; }
        public int Estado { get; set; }

    }
}
