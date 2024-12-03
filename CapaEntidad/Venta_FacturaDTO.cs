﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta_FacturaDTO
    {

        public int? ID_Venta { get; set; }
        public int? Estado { get; set; }
        public int? ID_Cliente { get; set; }
        public int? ID_Producto { get; set; }
        public int? ID_Vendedor { get; set; }

        public decimal? PrecioProducto { get; set; }

        public DateTime? Fecha_Venta { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Subtotal { get; set; }

        public decimal? Total { get; set; }

        public decimal? pagacon { get; set; }

        public decimal? cambio { get; set; }



    }
}
