using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{


    public class Venta_DetallesDTO
    {

            public int ID_Detalle { get; set; }
            public int ID_Venta { get; set; }
            public int? ID_Producto { get; set; }
            public int? Cantidad { get; set; }
            public decimal? PrecioProducto { get; set; }
        

    }
}
